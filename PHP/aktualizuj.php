<?php
$polaczenie = mysqli_connect("localhost", "root", "", "pracownia");
if (!$polaczenie) exit("Błąd połączenia z bazą danych");

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
  
    $kwalifikacja = $_GET['kwalifikacja'];
    $rok = $_GET['rok'];
    $sesja = $_GET['sesja'];
    $technologie = $_GET['technologie'];

    $zapytanie = "UPDATE autor SET nazwisko='$nazwisko', imie='$imie', narodowosc='$narodowosc', okres_tworzenia='$okres_tworzenia', jezyk='$jezyk', rodzaj_tworczosci='$rodzaj_tworczosci', osiagniecia='$osiagniecia' WHERE id_autora='$id'";
    $wynik = mysqli_query($polaczenie, $zapytanie);

    echo $wynik ? "Dane zostały zaktualizowane." : "Błąd zapytania! Dane nie zostały zaktualizowane.";
}

$autorzy = mysqli_query($polaczenie, "SELECT id_autora, imie, nazwisko FROM autor");
if (!$autorzy) {
    die("Błąd zapytania: " . mysqli_error($polaczenie));
}

$wybrany_autor = null;
if (isset($_GET['id_autora'])) {
    $id = $_GET['id_autora'];
    $wybrany_autor = mysqli_fetch_assoc(mysqli_query($polaczenie, "SELECT * FROM autor WHERE id_autora='$id'"));
}

mysqli_close($polaczenie);
?>

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Aktualizacja danych autora</title>
</head>
<body>

<h1>Wybierz autora do edycji</h1>
<form method="GET" action="">
    <label for="autor">Wybierz autora:</label>
    <select name="id_autora" id="autor">
        <?php while ($autor = mysqli_fetch_assoc($autorzy)): ?>
            <option value="<?= $autor['id_autora']; ?>" <?= (isset($id) && $id == $autor['id_autora']) ? 'selected' : ''; ?>>
                <?= $autor['imie'] . ' ' . $autor['nazwisko']; ?>
            </option>
        <?php endwhile; ?>
    </select>
    <input type="submit" value="Edytuj">
</form>

<?php if ($wybrany_autor): ?>
    <h2>Edytuj dane autora</h2>
    <form method="POST" action="">
        <input type="hidden" name="id_autora" value="<?= $wybrany_autor['id_autora']; ?>">
        <label for="nazwisko">Nazwisko:</label>
        <input type="text" name="nazwisko" value="<?= $wybrany_autor['nazwisko']; ?>"><br><br>

        <label for="imie">Imię:</label>
        <input type="text" name="imie" value="<?= $wybrany_autor['imie']; ?>"><br><br>

        <label for="narodowosc">Narodowość:</label>
        <input type="text" name="narodowosc" value="<?= $wybrany_autor['narodowosc']; ?>"><br><br>

        <label for="okres_tworzenia">Okres Tworzenia:</label>
        <input type="text" name="okres_tworzenia" value="<?= $wybrany_autor['okres_tworzenia']; ?>"><br><br>

        <label for="jezyk">Język:</label>
        <input type="text" name="jezyk" value="<?= $wybrany_autor['jezyk']; ?>"><br><br>

        <label for="rodzaj_tworczosci">Rodzaj Twórczości:</label>
        <input type="text" name="rodzaj_tworczosci" value="<?= $wybrany_autor['rodzaj_tworczosci']; ?>"><br><br>

        <label for="osiagniecia">Osiągnięcia:</label>
        <input type="text" name="osiagniecia" value="<?= $wybrany_autor['osiagniecia']; ?>"><br><br>

        <input type="submit" value="Zaktualizuj dane">
    </form>
<?php endif; ?>

</body>
</html>
