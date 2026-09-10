<?php
$conn = mysqli_connect("localhost", "root", "", "formularz");
if (!$conn)
{
    exit("Błąd połączenia");
}
$nazwisko = $_POST['nazwisko'];
$email = $_POST['E-mail'];
$wyksztalcenie = $_POST['wyksz'];

$dodaj = "Insert into form VALUES ('$nazwisko', '$email', '$wyksztalcenie', NULL)";
$zapytanie = mysqli_query($conn, $dodaj);
if (!$zapytanie===true)
{
    echo "Błąd";
}
else
{
    echo "Wpisano dane!";
}