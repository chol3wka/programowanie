
<?php

$conn = mysqli_connect('localhost','root','','firma');
if (!$conn) {
    exit('Błąd połączenia');
}

$result = $conn->query("SELECT imie, nazwisko, pensja FROM pracownicy WHERE plec = 'm' AND data_urodzenia > 1975-00-00 ORDER BY pensja DESC");
$result2 = $conn->query("SELECT imie, nazwisko FROM pracownicy WHERE plec = 'k' AND pensja = 2000 AND idplacowki = 2");
$result3 = $conn->query("SELECT MAX(pensja) AS max_pensja, MIN(pensja) AS min_pensja, AVG(pensja) AS srednia_pensja FROM pracownicy");
$result4 = $conn->query("SELECT id_pracownika, imie, nazwisko FROM pracownicy");

?>

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link rel='stylesheet' type='text/css' media='screen' href='./firma.css'>
    <script src='main.js'></script>
    <title>Baza danych o pracownikach firm</title>
</head>
<body>
    <header>
        <h1>BAZA DANYCH O PRACOWNIKACH</h1>
    </header>
    <section id="left">
        <h2>Informatycy poniżej roku 1975</h2>
        <?php
            if ($result ->num_rows>0){
                echo"<table><tr><th>Imie</th><th>Nazwisko</th><th>Pensja</th></tr>";
                while ($row = $result -> fetch_assoc()) {
                    echo "<tr><td>".$row['imie']."</td><td>".$row['nazwisko']."</td><td>".$row['pensja']."</td></tr>";
                }
                echo "</table>";
            } 
        ?>
    </section>
    <section id="right">
        <h2>Sekretarki firmy "Omega"</h2>
        <?php
        while($row = $result2 -> fetch_assoc()) {
                echo "<li>".$row['imie']." ".$row['nazwisko']."</li>";
            }
            echo "</ol>";
        ?>
        <hr>
        <?php
        if($row = $result3 -> fetch_assoc()){
                echo "<p>Najwyższa pensja: ".$row['max_pensja']."<br>";
                echo "<p>Najniższa pensja: ".$row['min_pensja']."<br>";
                echo "<p>Średnia pensja: ".$row['srednia_pensja']."</p>";
            }
        ?>
        <h3>Aktualizacja danych pracownika</h3>
        <form method="post" action="./aktualizuj.php">
            <label for="id_pracownika">ID Pracownika:</label>
            <select name="id_pracownika" id="id_pracownika" required>
                <?php
                if ($result4->num_rows > 0) {
                    while ($row = $result4->fetch_assoc()) {
                        
                        echo "<option value='" . $row['id_pracownika'] . "'>" . $row['id_pracownika'] . " - " . $row['imie'] . " " . $row['nazwisko'] . "</option>";
                    }
                } 
                ?>
            </select><br><br>

            <label for="imie">Imię:</label>
            <input type="text" name="imie" id="imie"><br><br>

            <label for="nazwisko">Nazwisko:</label>
            <input type="text" name="nazwisko" id="nazwisko"><br><br>

            <label for="pesel">PESEL:</label>
            <input type="text" name="pesel" id="pesel"><br><br>

            <label for="plec">Płeć (M/K):</label>
            <input type="text" name="plec" id="plec" maxlength="1"><br><br>

            <label for="data_urodzenia">Data urodzenia (RRRR-MM-DD):</label>
            <input type="date" name="data_urodzenia" id="data_urodzenia"><br><br>

            <label for="data_zatrudnienia">Data zatrudnienia (RRRR-MM-DD):</label>
            <input type="date" name="data_zatrudnienia" id="data_zatrudnienia"><br><br>

            <label for="zawod">Zawód:</label>
            <input type="text" name="zawod" id="zawod"><br><br>

            <label for="pensja">Pensja:</label>
            <input type="number" name="pensja" id="pensja"><br><br>

            <label for="dodatek">Dodatek:</label>
            <input type="number" name="dodatek" id="dodatek"><br><br>
            <input type="submit" value="Zaktualizuj dane">
        </form>
    </section>
    <footer>
        Autor: Weronika Cholewa
    </footer>
</body>
</html>

<?php
$conn ->close();
?>
