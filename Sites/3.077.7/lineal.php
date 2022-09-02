<?php
    require_once("./php/connect.php");
    $connection = connection();
    $result = mysqli_query($connection,"SELECT * FROM ventas ORDER BY fecha_venta");
    $x = array();//fechas
    $y = array();//montos

    while($v = mysqli_fetch_row($result))
    {
        $x[] = $v[1];
        $y[] = $v[2];
    }

    $datosX = json_encode($x);
    $datosY = json_encode($y);

?>
<div id="grafica_lineal"></div>

<script>
    function CrearCadenaLinha(json)
    {
        var parsed = JSON.parse(json);
        var arr = [];
        for(var x in parsed)
        {
            arr.push(parsed[x]);
        }
        return arr;
    }
</script>

<script type="text/javascript">

    datosX = CrearCadenaLinha('<?php echo $datosX; ?>');
    datosY = CrearCadenaLinha('<?php echo $datosY; ?>');

    var data = [
    {
        x: datosX,
        y: datosY,
        type: "scatter",
        line: {
            color: "darkgreen",
            width: 2.5
        },
        marker: {
            color: "teal",
            size: 7
        }
    }
];


    var layout = {
        title: "Estadisticas de Ventas - Grafica Lineal",
        xaxis:{
            tickangle: -45,
            title: "Fechas de Ventas"
        },
        yaxis: {
            title: "Montos de Ventas"
        },
        bargap: 0.07
    }

    Plotly.newPlot("grafica_lineal",data,layout);
</script>