<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pracownia</title>
</head>
<body>
    <h2>Zadania</h2>
    <form action="" method="get">
        Kwalifikacje: <input type="text" name="kwalifikacje" id="kwalifikacje">
        Rok: <input type="text" maxlength="4" name="rok" id="rok">
        Sesja: <input type="text"  name="sesja" id="sesja">
        Technologie: <input type="text" name="technologie" id="technologie">
        <button type="submit">Wyszukaj</button>
    </form>
</body>
</html>


<?php
$polaczenie = mysqli_connect("localhost", "root", "", "pracownia");
if (!$polaczenie) exit("Błąd połączenia z bazą danych");

$kwalifikacja = $_GET['kwalifikacja'];
$rok = $_GET['rok'];
$sesja = $_GET['sesja'];
$technologie = $_GET['technologie'];


$query = 'SELECT kwalifikacja.kwalifikacja, rok.rok, sesja.sesja, technologie_inf03.technologie, zadania.numer_zadania, zadania.opis FROM zadania JOIN rok ON rok_rok = rok.rok JOIN sesja ON sesja_sesja=sesja.sesja JOIN kwalifikacja ON kwalifikacja_kwalifikacja=kwalifikacja.kwalifikacja JOIN  technologie_inf03 ON technologie_inf03_technologie=technologie_inf03.technologie WHERE 1=1';

if ($kwalifikacja)$query.= "AND kwalifikacja='$kwalifikacja'";

if ($rok)$query.= "AND rok='$rok'";

if ($sesja)$query.= "AND sesja='$sesja'";

if ($technologie)$query.= "AND technologie='$technologie'";

$result = mysqli_query($conn, $query);
if($result){
    echo "<table><tr><th>Rok</th><th>Sesja</th>Numer zadania</th><th>Technologie</th><th>Opis</th></tr>";
    foreach ($result as $row){
        echo "<tr>";
        echo "<td>$row[rok]</td>";
        echo "<td>$row[sesja]</td>";
        echo "<td>$row[numer_zadania]</td>";
        echo "<td>$row[technologie]</td>";
        echo "<td>$row[opis]</td>";
        echo "</tr>";
        echo "</table>";
    }
}
?>
<?php
mysqli_close($polaczenie);
?>

