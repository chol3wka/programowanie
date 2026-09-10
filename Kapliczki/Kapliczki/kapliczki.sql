-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 03, 2025 at 07:49 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kapliczki`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `gmina`
--

CREATE TABLE `gmina` (
  `id_gmina` int(11) NOT NULL,
  `gmina` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `gmina`
--

INSERT INTO `gmina` (`id_gmina`, `gmina`) VALUES
(1, 'Kolonowskie'),
(2, 'Izbicko'),
(3, 'Ujazd'),
(4, 'Leśnica'),
(5, 'Jemielnica'),
(6, 'Zawadzkie'),
(7, 'Strzelce Opolskie');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `miejscowosc`
--

CREATE TABLE `miejscowosc` (
  `id_miejscowosc` int(11) NOT NULL,
  `id_gmina` int(11) NOT NULL,
  `miejscowosc` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `miejscowosc`
--

INSERT INTO `miejscowosc` (`id_miejscowosc`, `id_gmina`, `miejscowosc`) VALUES
(1, 1, 'Spórok'),
(2, 1, 'Staniszcze Małe'),
(3, 1, 'Staniszcze Wielkie'),
(4, 1, 'Kolonowskie'),
(5, 6, 'Zawadzkie'),
(6, 6, 'Kielcza'),
(7, 6, 'Żędowice'),
(8, 4, 'Czarnocin'),
(9, 4, 'Dolna'),
(10, 4, 'Góra Świętej Anny'),
(11, 4, 'Kadłubiec'),
(12, 4, 'Krasowa'),
(13, 4, 'Leśnica'),
(14, 4, 'Łąki Kozielskie'),
(15, 4, 'Poręba'),
(16, 4, 'Raszowa'),
(17, 4, 'Wysoka'),
(18, 4, 'Zalesie Śląskie'),
(19, 7, 'Błotnica Strzelecka'),
(20, 7, 'Dziewkowice'),
(21, 7, 'Grodzisko'),
(22, 7, 'Jędrynie'),
(23, 7, 'Kadłub'),
(24, 7, 'Kalinowice'),
(25, 7, 'Kalinów'),
(26, 7, 'Ligota Dolna'),
(27, 7, 'Ligota Górna'),
(28, 7, 'Niwki'),
(29, 7, 'Osiek'),
(30, 7, 'Płużnica'),
(31, 7, 'Rozmierka'),
(32, 7, 'Rozmierz'),
(33, 7, 'Rożniątów'),
(34, 7, 'Strzelce Opolskie'),
(35, 7, 'Sucha'),
(36, 7, 'Szczepanek'),
(37, 7, 'Szymiszów'),
(38, 7, 'Warmątowice'),
(39, 5, 'Barut'),
(40, 5, 'Centawa'),
(41, 5, 'Gąsiorowice'),
(42, 5, 'Jemielnica'),
(43, 5, 'Łaziska'),
(44, 5, 'Piotrówka'),
(45, 5, 'Wierchlesie'),
(46, 3, 'Balcarzowice'),
(47, 3, 'Buczki'),
(48, 3, 'Grzeboszowice'),
(49, 3, 'Jaryszów'),
(50, 3, 'Klucz'),
(51, 3, 'Księży Las'),
(52, 3, 'Niezdrowice'),
(53, 3, 'Nogowczyce'),
(54, 3, 'Olszowa'),
(55, 3, 'Sieroniowice'),
(56, 3, 'Stary Ujazd'),
(57, 3, 'Ujazd'),
(58, 3, 'Zimna Wódka'),
(59, 2, 'Borycz'),
(60, 2, 'Grabów'),
(61, 2, 'Izbicko'),
(62, 2, 'Krośnica'),
(63, 2, 'Ligota Czamborowa'),
(64, 2, 'Otmice'),
(65, 2, 'Poznowice'),
(66, 2, 'Siedlec'),
(67, 2, 'Sprzęcice'),
(68, 2, 'Suchodaniec'),
(69, 2, 'Utrata'),
(70, 4, 'Lichynia');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `obiekt`
--

CREATE TABLE `obiekt` (
  `id_obiekt` int(11) NOT NULL,
  `id_gmina` int(11) NOT NULL,
  `id_miejscowosc` int(11) NOT NULL,
  `id_typ` int(11) NOT NULL,
  `ulica` varchar(35) NOT NULL,
  `opis` text NOT NULL,
  `fundator` varchar(35) NOT NULL,
  `budowniczy` varchar(25) NOT NULL,
  `rok` varchar(10) NOT NULL,
  `foto` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `obiekt`
--

INSERT INTO `obiekt` (`id_obiekt`, `id_gmina`, `id_miejscowosc`, `id_typ`, `ulica`, `opis`, `fundator`, `budowniczy`, `rok`, `foto`) VALUES
(1, 3, 46, 2, '', 'Ten drewniany krzyż został wzniesiony około 1920 r., aby upamiętnić żołnierzy poległych w czasie I wojny światowej. Ciała spoczywających w tym miejscu żołnierzy zostały w 1922 r. przewiezione na centralny cmentarz w Kędzierzynie – Koźlu. \r\nStojący obecnie krzyż został odnowiony w 1993 r. i do dzisiejszego dnia mieszkańcy wsi otaczają go swoja opieką.\r\n', '', '', '1993', 'IMG_3391.jpg'),
(2, 3, 46, 2, '', 'Kolejny drewniany krzyż, o wysokości ok. 4 m, znajduje się na skrzyżowaniu dróg wiodących z Kotulina-Skały do Sieroniowic. Korpus krzyża to pomalowany odlew gipsowy. Otoczony ozdobnym, metalowym płotkiem. Czas powstania krzyża i jego fundatorzy nie są znani.', '', '', '', 'IMG_2221.jpg'),
(3, 3, 46, 2, '', '', '', '', '', ''),
(4, 5, 39, 2, 'Strzelecka', '', '', '', '', 'IMG_5332.jpg'),
(5, 5, 39, 2, 'Polna', 'Krzyż ten zlokalizowany jest na rogu ulicy Polnej i Marka Prawego. Stoi w tym miejscu od 1896 r. Raz w roku, przed uroczystością odpustową, jest on nieodpłatnie odmalowywany przez opiekującego się nim Pana P. Wycisło. Mieszkańcy Barutu przystrajają go kwiatami i zniczami. Widnieje na nim jakże wymowny napis: „O Herr erbarme dich unser” (Panie zmiłuj się nad nami)...', '', '', '1896', ''),
(6, 7, 19, 1, '', 'Kapliczka w Błotnicy Strzeleckiej pochodzi z ok. połowy XIX w.. Jest murowana oraz otynkowana. Ma kształt prostokątny. Jest sklepiona kolebkowo. Nakryta jest dachem siodłowym, krytym dachówką, na nim sześcioboczna wieżyczka, w której umieszczony jest mały dzwon. \r\nWe wnętrzu kapliczki znajduje się murowany ołtarz, nad którym zawieszone są obrazy przedstawiające Matkę Boską (w centrum), św. Franciszka oraz św. Jana Nepomucena (po bokach), a także niewielka, gipsowa figurka wyobrażająca Najświętszą Marie Pannę.\r\n', '', '', '', ''),
(7, 7, 19, 2, '', 'Naprzeciwko szkoły podstawowej, przy przebiegającej przez Błotnicę drodze międzynarodowej 94, w cieniu drzew stoi kamienny krzyż, otoczony ozdobnym, metalowym płotkiem koloru białego.\r\nHistoria jego powstania wiąże się z ówczesnymi właścicielami pałacyku położonego w błotnickim parku, rodzina Possadowsky – Wehner von Grüben. Jednym z członków tej rodziny był Hans – Adam, który w miejscu, gdzie dziś znajduje się krzyż, chciał wybudować kościół. Zakupił już nawet wszystkie potrzebne materiały, jednak nagła choroba i śmierć pokrzyżowały jego plany. Spadkobierca Hansa-Adama sprzedał nagromadzony przez jego poprzednika budulec, a na tym miejscu postawił kamienny krzyż.\r\nNa marmurowej podstawie krzyża wyryte były kiedyś w języku niemieckim słowa modlitwy do miłosierdzia boskiego. Dziś miejsce na napis jest puste. Powyżej, w murowanej wnęce umieszczona jest figura Matki Boskiej. Krzyż jest zadbany i okresowo odnawiany przez mieszkańców.\r\n', '', '', '', ''),
(8, 2, 59, 1, 'Wolności/Wojska Polskiego', 'Na skrzyżowaniu ulic: Wolności i Wojska Polskiego w Boryczy znajduje się murowana z cegły kapliczka. W miejscu, gdzie dziś stoi kapliczka dawniej był rów. Kiedyś zdarzył się w tym miejscu tragiczny wypadek. W czasie burzy z wichurą przewróciła się tam furmanka z sianem zabijając kobietę. Mieszkańcy umieścili w tym miejscu na pamiątkę tego wydarzenia obrazek. 20 lipca 1934 roku panowie: P. Hendel i T. Glück wybudowali kapliczkę. W jej trzech niszach umieszczono trzy figury wyobrażające: Matkę Boską (w środku), św. Józefa z dzieciątkiem Jezus (z lewej strony) oraz św. Franciszka z dzieciątkiem Jezus (z prawej strony). ', '', '', '', ''),
(9, 2, 59, 2, '', '', '', '', '1903', 'IMG_0766.jpg'),
(10, 2, 59, 1, 'Wojska Polskiego', 'Kapliczka pochodzi z 1 połowy XIX w. murowana, otynkowana, prostokątna z kwadratową wieżą od frontu, dach siodłowy kryty dachówką, wieża rozdzielona gzymsem na dwie kondygnacje, z których górna o ściętych narożnikach. Okna i drzwi zamknięte półkoliście. Wieża pokryta jest dachem czterospadowym z latarnią.\r\nBudowniczymi kapliczki byli bracia Warzechowie. Maks Warzecha był w latach 20-tych ubiegłego stulecia właścicielem młyna w Boryczy, a jego brat, który wybudował ów młyn wyjechał wkrótce po tym, jak został on utracony przez grę w karty, do Ameryki i zaginął tam bez wieści\r\nWe wnętrzu kapliczki znajduje się obraz matki Boskiej Różańcowej, malowany na blasze, o charakterze barokowym oraz dwie figury z tego okresu, które w okresie odpustu prowadzone są w uroczystej procesji do kościoła w Krośnicy oraz do kościoła w Raszowej. Obok kapliczki znajduje się marmurowy krzyż.\r\n', 'Bracia Warzecha', 'Bracia Warzecha', '', ''),
(11, 2, 59, 2, '', 'Przy wjeździe do Boryczy od strony Krośnicy, po prawej stronie, pod dorodnymi kasztanami stoi okazały krzyż. Z tyłu wyryte są nazwiska jego fundatorów: „Joseph i Franciszka Szczeponek 1902”. Po obu bokach krzyża widnieją wyryte napisy w języku niemieckim. Z prawej strony: „Rette meine Seele”; natomiast z lewej strony: „O Herr erbarme Dich unser”.\r\nW dolnej części krzyża, z przodu, znajduje się nisza, w której umieszczona jest figurka Matki Boskiej. Obecnie krzyżem opiekuje się rodzina Niczka.\r\n', 'Joseph i Franciszka Szczeponek', 'J. Lika Stubendorf', '1902', 'IMG_4632.jpg'),
(12, 2, 59, 2, '', '', '', '', '', 'IMG_0488.jpg'),
(13, 2, 59, 2, '', 'Na leśnym pagórku, przy drodze prowadzącej z Boryczy do Grodziska stoi piękny dębowy krzyż. Według miejscowej legendy, w miejscu gdzie stoi krzyż pochowano żołnierzy francuskich zmarłych od ran lub na skutek epidemii tyfusu w trakcie odwrotu armii napoleońskiej spod Moskwy.\r\nSkąd wzięła się ta dziwna nazwa pagórka? Według przekazów najstarszych mieszkańców, na tym piaszczystym pagórku, otoczonym lasem, nigdy nic nie rosło. Chociaż dzisiaj na „Łysej Górze” rosną drzewa, to miejsce to jest ciągle żywe w ludzkiej pamięci. \r\nZ „Łysą Górą” związanych jest kilka miejscowych legend. Podobno od zawsze ludzie bali się strachów, które tam można było spotkać. Wokół mogiły miała przechadzać się biała dama, a sami mieszkańcy starali się zjechać z pól położonych wokół pagórka jeszcze zanim dzwon kapliczki we wsi rozlegał się na Anioł Pański. Inna legenda głosi, że nawet w dzień (w samo południe) spotkać tam można czasem postać, wokół której krążą dzikie psy.\r\n', '', '', '', ''),
(14, 4, 70, 2, '', '', '', '', '', ''),
(15, 4, 70, 1, 'Daszyńskiego', 'W środku wsi przy ulicy Daszyńskiego stoi kapliczka – dzwonnica. Pochodzi ona z XVII wieku. Kapliczka jest murowana i otynkowana. Nad kapliczką unosi się drewniana dzwonnica pokryta czterospadowym dachem. Wąskie obrzeże kapliczki i dach pokryte są gontem (zwanym też szerdzioł). Na samym szczycie dachu na metalowej podstawce stoi metalowa kula, a na niej metalowy krzyż. W murowanej kapliczce są dwa okrągłe okna (na wschodniej i zachodniej ścianie). Od strony południowej czterema stopniami wchodzi się do wnętrza kapliczki. W dzwonnicy do połowy lat czterdziestych XX wieku znajdował się mały dzwon zwany sygnaturką. Dźwięki sygnaturki ostrzegały mieszkańców przed niebezpieczeństwem i informowały o wybuchu pożaru we wiosce i w okolicy, oznajmiały zgon mieszkańca wsi i towarzyszyły mu w jego ostatniej drodze na cmentarz parafialny w Zalesiu Śląskim. Kiedy w 1945 roku w budynku karczmy utworzono kościół filialny p.w. św. Józefa, dzwon z kapliczki zdjęto i zawieszono na drewnianym zadaszonym rusztowaniu przed kościołem, gdzie obecnie znajduje się głaz – pomnik poległych i zmarłych w czasie II wojny światowej. Tym to dzwonem pierwszy kościelny Stanisław Swoboda rano w południe i wieczorem dzwonił na Anioł Pański oraz na pół godziny przed każdą Mszą Św., i nabożeństwem. Po nim tę funkcję przejęła Praksydra Kołodziej. W 1975 r. gruntownie przebudowano budynek Kościoła i wybudowano wieżę kościelną, w której zawieszono inny dzwon. Prawdopodobnie był to stary dzwon z kościoła z Zalesia Śląskiego. W Zalesiu Śląskim w dniu 16 października 1973 roku biskup pomocniczy Wacław Wycisk poświęcił nowe dzwony. Losy dzwonu z kapliczki były nieznane aż do roku 2008. 11 lipca dzwon zawieszono z powrotem na dawne miejsce. W latach 60-tych przeprowadzono gruntowny remont kapliczki-dzwonnicy i pokrycia dachowego. Obok kapliczki na czterostopniowym podwyższeniu stoi masywny krzyż kamienny z zawieszoną na nim figurą ukrzyżowanego Pana Jezusa. Krzyż ten powstał na początki XX wieku. Jak głosi legenda, krzyż jest wotum dziękczynnym mieszkańców wsi Lichynia za to, że powrócili do rodzinnej wioski z wojennej tułaczki.', '', '', 'XVII wiek', 'IMG_3799.jpg'),
(16, 4, 70, 2, 'Daszyńskiego', 'W centrum miejscowości znajduje się także okazały, kamienny krzyż stojący na trzystopniowym, schodkowym postumencie. Jego wybudowanie przypada na schyłek XIX stulecia (ok. 1889 r.). W dzisiejszych czasach, w trakcie odprawiania nabożeństw majowych, wierni gromadzą się przy tym krzyżu, aby wyprosić potrzebne łaski dla siebie i swoich bliskich.', '', '', '1889', ''),
(17, 4, 70, 2, 'Daszyńskiego', '', '', '', '', ''),
(18, 6, 5, 1, '', '', '', '', '', ''),
(19, 6, 5, 2, 'Andrzeja', '', '', '', '', 'IMG_4763.jpg'),
(20, 6, 5, 2, 'Nowe Osiedle', 'Ufundowany z okazji Jubieluszu roku 2000', '', '', '2000', ''),
(21, 6, 5, 2, 'Chopina', 'Miejscem kultu mieszkańców Zawadzkiego jest drewniany krzyż przy ul. F. Chopina. Jego fundatorem był p. K. Kusz, który wraz z innymi mieszkańcami postawił go w tym miejscu w 1947 r. jako podziękowanie za ocalenie życia w czasie II wojny światowej.\r\nCo roku w maju krzyż staje się miejscem, do którego zdążają procesje krzyżowe. Wierni uczestniczący w nabożeństwie modlą się o urodzaje i błogosławieństwo we wszystkich swoich zajęciach.\r\n', 'K. Kusz', '', '1947', 'IMG_4777.jpg'),
(22, 6, 5, 2, 'Opolska', 'Krzyż przy ulicy Opolskiej został wybudowany w 1903 roku. Franciszek Kura widząc rozpadający się krzyż i dzwonnicę drewnianą, które stały po przeciwnej stronie ulicy, wystąpił z inicjatywą wybudowania nowego krzyża betonowo – marmurowego na swoim podwórku. Finansowo wspierali go sąsiedzi. W czasie zbiórki pieniędzy przeznaczonych na krzyż jedna mieszkanka powiedziała: „że na krzyż nie da pieniędzy, bo nie będzie się żegnać.” Dzień przed poświęceniem już postawionego krzyża, przechodziła obok niego nie przeżegnawszy się ani razu upadła martwa \r\nW 1938 roku na rozkaz jednego z naczelników partii nazistowskiej miał zostać skuty napis w języku polskim. Człowiek, który miał to wykonać skuł tylko napis: \r\n„W krzyżu jest moja nadzieja”. Okoliczni mieszkańcy nie pozwolili na dalsze kucie. W nocy ktoś przekreślił resztę napisu w języku polskim czarną farbą, której nie dało się usunąć. Z tego powodu tablicę z napisem zagipsowano. Krzyż został powtórnie poświęcony w maju 1939 roku przez księdza Milera. Po wojnie gips został usunięty, a wraz z nim zeszła czarna farba. Odnowiony krzyż stoi do dzisiaj, strzegąc okolicznych mieszkańców i błogosławiąc ich urodzajom. Co roku w maju odbywają się do tego krzyża procesje krzyżowe. W 2003 roku minęło 100 lat od postawienia krzyża. \r\n Na krzyżu jest umieszczony także następujący napis w języku polskim:\r\n„Miłosierny Jezu Ratuj dusze w czyśćcu cierpiące”.\r\n', '', 'Franciszek Kura', '1903', ''),
(23, 6, 5, 2, 'Mickiewicza/Szymanowskiego', 'Krzyż został postawiony przez parafian z kościoła p.w. Najświętszego Serca Pana Jezusa. Znajduje się na skrzyżowaniu ulic A. Mickiewicza i K. Szymanowskiego, tuż obok torów kolejowych. Przed jego postawieniem w miejscu tym dochodziło do wielu śmiertelnych wypadków. Odkąd został w tym miejscu ufundowany krzyż, tuż obok torów kolejowych, nie doszło do żadnego wypadku śmiertelnego na tym przejeździe. W maju odbywają się do tego krzyża procesje majowe.', '', '', '', ''),
(24, 1, 4, 2, 'Arki Bożka', 'Jest to dawny krzyż misyjny przeniesiony z placu kościelnego. Pierwotny krzyż pochodził z 19.07.1958 r., a obecny, dębowy został poświęcony 27.10.1973 r.', '', '', '1958', ''),
(25, 1, 4, 1, 'Ks. Czerwionki', '', '', '', '1860', ''),
(26, 1, 50, 1, '1-go Maja', '', '', '', '1820', ''),
(27, 1, 4, 2, '1-go Maja', 'Kapliczka p.w. św. Anny pochodzi najprawdopodobniej z XIX w. Wiadomo bowiem, że od 1893 r. dzwonił w niej jeden z mieszkańców osady nazwiskiem Czupała. Głos dzwonu rozbrzmiewał na Anioł Pański, gdy wybuchł pożar, a także oznajmiał śmierć któregoś z mieszkańców wsi. Pierwotnie miał w tym miejscu stać krzyż, a potem zastąpiła go murowana kapliczka. W jednym z pożarów jakie dotknęły wieś Kolonowskie w początkach ubiegłego stulecia spłonęło wiele zabudowań, jednym  z nielicznych jaki ocalał z pożogi był dom stojący właśnie kapliczki św. Anny (w niej samej ogień strawił dach). W 1948 r. obiekt został odrestaurowany i odmalowany. ', '', '', '', 'IMG_5574.jpg'),
(28, 1, 4, 1, 'Haraszowskie', '', '', '', '', ''),
(29, 1, 4, 2, 'Haraszowskie', 'Podziękowanie za dar powołania córki do zakonu', 'Karol i Jadwiga Drzymała', '', '1927', ''),
(30, 1, 4, 2, 'Konopnickiej', '', '', '', '', ''),
(31, 1, 4, 2, 'Leśna', '', '', '', '', ''),
(32, 1, 4, 2, '1-go Maja', 'Jedyny z powiecie krzyż z dołączoną kapliczką', '', '', '', 'IMG_2522.jpg');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typ`
--

CREATE TABLE `typ` (
  `id_typ` int(11) NOT NULL,
  `typ` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `typ`
--

INSERT INTO `typ` (`id_typ`, `typ`) VALUES
(1, 'Kapliczka'),
(2, 'Krzyż');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `gmina`
--
ALTER TABLE `gmina`
  ADD PRIMARY KEY (`id_gmina`);

--
-- Indeksy dla tabeli `miejscowosc`
--
ALTER TABLE `miejscowosc`
  ADD PRIMARY KEY (`id_miejscowosc`),
  ADD KEY `miejscowosc_ibfk_1` (`id_gmina`);

--
-- Indeksy dla tabeli `obiekt`
--
ALTER TABLE `obiekt`
  ADD PRIMARY KEY (`id_obiekt`),
  ADD KEY `id_gmina` (`id_gmina`),
  ADD KEY `id_miejscowosc` (`id_miejscowosc`),
  ADD KEY `id_typ` (`id_typ`);

--
-- Indeksy dla tabeli `typ`
--
ALTER TABLE `typ`
  ADD PRIMARY KEY (`id_typ`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gmina`
--
ALTER TABLE `gmina`
  MODIFY `id_gmina` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `miejscowosc`
--
ALTER TABLE `miejscowosc`
  MODIFY `id_miejscowosc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `obiekt`
--
ALTER TABLE `obiekt`
  MODIFY `id_obiekt` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `typ`
--
ALTER TABLE `typ`
  MODIFY `id_typ` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `miejscowosc`
--
ALTER TABLE `miejscowosc`
  ADD CONSTRAINT `miejscowosc_ibfk_1` FOREIGN KEY (`id_gmina`) REFERENCES `gmina` (`id_gmina`);

--
-- Constraints for table `obiekt`
--
ALTER TABLE `obiekt`
  ADD CONSTRAINT `obiekt_ibfk_1` FOREIGN KEY (`id_gmina`) REFERENCES `gmina` (`id_gmina`),
  ADD CONSTRAINT `obiekt_ibfk_2` FOREIGN KEY (`id_miejscowosc`) REFERENCES `miejscowosc` (`id_miejscowosc`),
  ADD CONSTRAINT `obiekt_ibfk_3` FOREIGN KEY (`id_typ`) REFERENCES `typ` (`id_typ`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
