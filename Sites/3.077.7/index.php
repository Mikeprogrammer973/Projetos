<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./librarias/bootstrap/bootstrap/css/bootstrap.css">
    <script src="./librarias/jquery-3.6.1.min.js"></script>
    <script src="./librarias/plotly-2.14.0.min.js"></script>
    <title>Gráficos Com Plotly</title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-primary">
                    <div class="panel panel-heading" style="font:bold 2em cursive;text-align:center;background-color:teal;color:white;">
                        Graficas con Plotly js
                    </div>
                    <div class="panel panel-body">
                        <div class="row">
                            <div class="col-sm-6">
                                <div id="load-lineal">

                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div id="load-barras">
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>

<script>
    $(document).ready(function(){
        $('#load-lineal').load('lineal.php');
        $('#load-barras').load('barras.php');
    });
</script>