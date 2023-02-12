  google.charts.load('current', {'packages':['bar']});
      google.charts.setOnLoadCallback(drawChart);

      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Tháng', 'Bài Hát'],
          ['1', 50],
          ['2', 60],
          ['3', 120],
          ['4', 40],
          ['5', 10],
          ['6', 1],
          ['7', 20],
          ['8', 80],
          ['9', 90],
          ['10', 30],
          ['11', 25],
          ['12', 45]
        ]);

        var options = {
          chart: {
            title: '',
            subtitle: '',
          }
        };

        var chart = new google.charts.Bar(document.getElementById('columnchart_material'));

        chart.draw(data, google.charts.Bar.convertOptions(options));
      }