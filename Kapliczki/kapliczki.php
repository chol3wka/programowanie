<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kapliczki</title>
</head>
<body>
    <h1>Wyszukaj kapliczkę</h1>

    <?php

    $conn = mysqli_connect('localhost','root','','kapliczki');
    
    if(isset($_POST['gmina']) && isset($_POST['miejscowosc']) && $_POST['typ']){

        $gmina = $_POST['gmina'];
        $miejscowosc = $_POST['miejscowosc'];
        $typ = $_POST['typ'];

        $query1 = "SELECT * FROM gmina";
        $result1 = mysqli_query($conn, $query1);

        $query2 = "SELECT * FROM miejscowosc";
        $result2 = mysqli_query($conn, $query2);

        $query3 = "SELECT * FROM typ";
        $result1 = mysqli_query($conn, $query3);

    }else{
        echo "<p> Zaznacz wszystkie kryteria. </p>";
    }

    ?>
    <form action="kapliczki.php" method="post">
    Gmina:
    <select name="gmina" id="gmina">
    <?php
        while($row = mysqli_fetch_array($result1)){
            echo "<option> $row[1]</option>";
        }
    ?>
    </select>
    Miejscowość:
    <select name="miejscowosc" id="miejscowosc">

    </select>
    Typ:
    <select name="typ" id="typ">

    </select>
    <button type="submit">Szukaj</button>
</form>
</body>
</html>