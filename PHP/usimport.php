<?php
header('Content-Type: text/html; charset=UTF-8');

function fetchApiData($url) {
    $response = file_get_contents($url);
    if ($response === FALSE) {
        return [];
    }
    return json_decode($response, true);
}

$apiKey = '8b28ec2bfc7f42c:bk1m6rtupv9xd73';
$aseanCountries = [
    'Malaysia' => "https://api.tradingeconomics.com/comtrade/historical/USAMYSXX851?c=$apiKey",
    'Indonesia' => "https://api.tradingeconomics.com/comtrade/historical/USAIDNXX851?c=$apiKey",
    'Thailand' => "https://api.tradingeconomics.com/comtrade/historical/USATHAXX851?c=$apiKey",
    'Philippines' => "https://api.tradingeconomics.com/comtrade/historical/USAPHLXX851?c=$apiKey",
    'Singapore' => "https://api.tradingeconomics.com/comtrade/historical/USASGPXX851?c=$apiKey",
    'Vietnam' => "https://api.tradingeconomics.com/comtrade/historical/USAVNMXX851?c=$apiKey",
    'Brunei' => "https://api.tradingeconomics.com/comtrade/historical/USABRNXX851?c=$apiKey",
    'Laos' => "https://api.tradingeconomics.com/comtrade/historical/USALAOXX851?c=$apiKey",
    'Myanmar' => "https://api.tradingeconomics.com/comtrade/historical/USAMMRXX851?c=$apiKey",
    'Cambodia' => "https://api.tradingeconomics.com/comtrade/historical/USAKHMXX851?c=$apiKey"
];

$countryData = [];
foreach ($aseanCountries as $country => $url) {
    $data = fetchApiData($url);
    $formattedData = array_map(function($item) {
        return [
            'date' => (new DateTime($item['date']))->format('Y'),
            'value' => $item['value']
        ];
    }, $data);

    if ($country === 'Vietnam') {
        $formattedData = array_filter($formattedData, function($item) {
            return (int)$item['date'] >= 1994;
        });
    } elseif ($country === 'Cambodia') {
        $formattedData = array_filter($formattedData, function($item) {
            return (int)$item['date'] >= 1993;
        });
    }

    $countryData[$country] = $formattedData;
}

$allDates = [];
foreach ($countryData as $data) {
    $dates = array_column($data, 'date');
    $allDates = array_merge($allDates, $dates);
}
$uniqueDates = array_unique($allDates);
sort($uniqueDates);

$totalValues = array_fill_keys($uniqueDates, 0);

foreach ($countryData as $data) {
    foreach ($data as $item) {
        $date = $item['date'];
        if (isset($totalValues[$date])) {
            $totalValues[$date] += $item['value'];
        }
    }
}

$combinedTotalData = [
    'labels' => $uniqueDates,
    'values' => array_map(function($date) use ($totalValues) {
        return $totalValues[$date];
    }, $uniqueDates)
];
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>United States Import Value of Electrical and Electronic Equipment from ASEAN Countries</title>
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chartjs-plugin-trendline"></script>
</head>
<body>
    <h1>United States Import Value of Electrical and Electronic Equipment from ASEAN Countries</h1>
    <canvas id="tradeChart"></canvas>
    <script>
        const data = <?php echo json_encode($countryData); ?>;
        const uniqueDates = <?php echo json_encode($uniqueDates); ?>;
        const combinedTotal = <?php echo json_encode($combinedTotalData); ?>;

        function prepareChartData(countryData) {
            const dataMap = {};
            uniqueDates.forEach(date => dataMap[date] = 0);
            countryData.forEach(item => dataMap[item.date] = item.value);

            return {
                labels: uniqueDates,
                values: uniqueDates.map(date => dataMap[date])
            };
        }

        const datasets = [];
        Object.keys(data).forEach(country => {
            const chartData = prepareChartData(data[country]);
            datasets.push({
                label: country,
                data: chartData.values,
                borderColor: getRandomColor(),
                backgroundColor: getRandomColor(0.2),
                trendlineLinear: {
                    style: "rgba(0,0,0,.8)",
                    lineStyle: "solid",
                    width: 2
                }
            });
        });

        datasets.push({
            label: 'Total ASEAN',
            data: combinedTotal.values,
            borderColor: 'rgba(0,0,0,1)',
            backgroundColor: 'rgba(0,0,0,0.2)',
            trendlineLinear: {
                style: "rgba(255,0,0, .8)",
                lineStyle: "solid",
                width: 2
            }
        });

        function getRandomColor(alpha = 1) {
            const r = Math.floor(Math.random() * 255);
            const g = Math.floor(Math.random() * 255);
            const b = Math.floor(Math.random() * 255);
            return `rgba(${r}, ${g}, ${b}, ${alpha})`;
        }

        const ctx = document.getElementById('tradeChart').getContext('2d');
        const chart = new Chart(ctx, {
            type: 'line',
            data: {
                labels: uniqueDates,
                datasets: datasets
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true,
                        ticks: {
                            callback: function(value) {
                                return '$' + value.toLocaleString();
                            }
                        }
                    }
                },
                plugins: {
                    tooltip: {
                        callbacks: {
                            title: function(context) {
                                return 'Year: ' + context[0].label;
                            },
                            label: function(context) {
                                let label = context.dataset.label || '';
                                if (label) {
                                    label += ': ';
                                }
                                if (context.parsed.y !== null) {
                                    label += '$' + context.parsed.y.toLocaleString();
                                }
                                return label;
                            },
                            afterLabel: function(context) {
                                if (context.dataset.label === 'Total ASEAN') {
                                    return '';
                                }
                                const year = context.label;
                                let totalForYear = 0;
                                Object.keys(data).forEach(country => {
                                    const countryData = prepareChartData(data[country]);
                                    totalForYear += countryData.values[uniqueDates.indexOf(year)] || 0;
                                });
                                return 'Total for ' + year + ': $' + totalForYear.toLocaleString();
                            }
                        }
                    },
                    trendlineLinear: {
                        style: "rgba(255,105,180, .8)",
                        lineStyle: "solid",
                        width: 2
                    }
                }
            }
        });
    </script>
</body>
</html>
