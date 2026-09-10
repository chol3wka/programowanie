
<?php

$conn = mysqli_connect('localhost','root','','firma');
if (!$conn) {
    exit('Błąd połączenia');
}

$id_pracownika = $_POST['id_pracownika'];
$imie = $_POST['imie'];
$nazwisko = $_POST['nazwisko'];
$pesel = $_POST['pesel'];
$plec = $_POST['plec'];
$data_urodzenia = $_POST['data_urodzenia'];
$data_zatrudnienia = $_POST['data_zatrudnienia'];
$zawod = $_POST['zawod'];
$pensja = $_POST['pensja'];
$dodatek = $_POST['dodatek'];

$sql = "UPDATE pracownicy SET 
    imie = '$imie',
    nazwisko = '$nazwisko',
    pesel = '$pesel',
    plec = '$plec',
    data_urodzenia = '$data_urodzenia',
    data_zatrudnienia = '$data_zatrudnienia',
    zawod = '$zawod',
    pensja = '$pensja',
    dodatek = '$dodatek'
    WHERE id_pracownika = $id_pracownika";


if ($conn->query($sql) === TRUE) {
    echo "Dane pracownika zostały zaktualizowane.";
} else {
    echo "Błąd podczas aktualizacji: " . $conn->error;
}


$conn->close();
?>
