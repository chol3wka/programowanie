<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Egzamin INF.03</title>
</head>
<body>
    <main>
    <form method="post">
    <?php

    $conn = mysqli_connect('localhost','root','','pracownia');

    $kwalifikacje = "SELECT * FROM kwalifikacja";
    $kwalifikacje_num_rows = mysqli_num_rows(mysqli_query($conn, $kwalifikacje));

    $rok = "SELECT * FROM rok";
    $rok_num_rows = mysqli_num_rows(mysqli_query($conn, $rok));

    $sesja = "SELECT * FROM sesja";
    $sesja_num_rows = mysqli_num_rows(mysqli_query($conn, $sesja));

    $technologie = "SELECT * FROM technologie";
    $technologie_num_rows = mysqli_num_rows(mysqli_query($conn, $technologie));

?>
        <select name="kwalifikacja" id="kwalifikacja">
        <?php
            for ($i = 0; $i <= $kwalifikacje_num_rows; $i++){
                $kwalifikacje_fetch = mysqli_fetch_assoc(mysqli_query($conn, $kwalifikacje));
                echo '<option value="'.$kwalifikacje_fetch[0].'">'.$kwalifikacje_fetch[0].'</option>';
            }

        ?>
        </select>
        <select name="rok" id="rok">
        <?php
            for ($i = 0; $i < $rok_num_rows; $i++) {
                $rok_fetch = mysqli_fetch_array($rok);
                echo '<option value="'.$rok_fetch[0].'"'>'.$rok_fetch[0].'"</option>'";
            };
        ?>
        </select>
        <select name="sesja" id="sesja">
        <?php
            for ($i = 0; $i < $sesja_num_rows; $i++){
                $sesja_fetch = mysqli_fetch_array($sesja);
                echo '<option value="'.$sesja_fetch[0].'"'>'.$sesja_fetch[0].'"</option>'";
            }
        ?>
        </select>
        <select name="technologie" id="technologie">
        <?php
            for ($i = 0; $i < $technologie_num_rows; $i++){
                $technologie_fetch = mysqli_fetch_array($technologie);
                echo '<option value="'.$technologie_fetch[0].'">'.$technologie_fetch[0].'</option>'";"
            }
        ?>
        </select>
        <button type="button">Zapisz</button>
    </form>
    </main>
</body>
</html>