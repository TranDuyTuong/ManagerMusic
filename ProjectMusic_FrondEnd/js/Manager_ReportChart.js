google.charts.load("current", {packages:["calendar"]});
google.charts.setOnLoadCallback(drawChart);

function drawChart() {
    var dataTable = new google.visualization.DataTable();
    dataTable.addColumn({ type: 'date', id: 'Date' });
    dataTable.addColumn({ type: 'number', id: 'Won/Loss' });
    dataTable.addRows([
       [ new Date(2021, 11 - 1, 13), 100 ],
       [ new Date(2021, 12 - 1, 14), 300 ],
       [ new Date(2021, 3, 15), 400 ],
       [ new Date(2021, 3, 16), 500 ],
       [ new Date(2021, 3, 17), 100000 ],

     ]);

    var chart = new google.visualization.Calendar(document.getElementById('calendar_basic'));
    var options = {
      height: 500,
      calendar: {
        monthLabel: {
          fontName: 'Times-Roman',
          fontSize: 12,
          color: '#981b48',
          bold: true,
          italic: true
        },
        monthOutlineColor: {
          stroke: '#981b48',
          strokeOpacity: 0.8,
          strokeWidth: 2
        },
        unusedMonthOutlineColor: {
          stroke: '#bc5679',
          strokeOpacity: 0.8,
          strokeWidth: 1
        },
        cellSize: 15,
        underMonthSpace: 16,
        yearLabel: {
            fontName: 'Times-Roman',
            fontSize: 32,
            color: '#1A8763',
            bold: true,
            italic: true
          }
      }
    };

    chart.draw(dataTable, options);
}