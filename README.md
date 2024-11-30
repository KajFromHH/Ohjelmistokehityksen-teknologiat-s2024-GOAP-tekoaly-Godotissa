# Ohjelmistokehityksen teknologiat syksy 2024: GOAP tekoäly Godotissa

Kaj Peter Jansson
Tradenomi tietojenkäsittely
Haaga-Helia ammattikorkeakoulu
2024

## Sisältöluettelo

1. Johdanto
2. Teoriaa
3. Työkalut
4. Toteutus
5. Tulos ja tulkinta
6. Appendix A: Työpäiväkirja
7. Lähteet

## 1. Johdanto
Tämä projekti on seminaarityö Ohjelmistokehityksen teknologiat -kurssille syksy 2024.
Seminaarityö on lopputyö koko kursille, jossa pitää käsitellä jonkun kurssin aiheita.
Suositus on, että aihe on projektin tekijälle (Kaj Peter Jansson) kiinnostava ja motivoitava. 

### 1.1 Tausta ja tavoitteet
Minä, Kaj Peter Jansson, kiinnostaa tutkia tekoälyä peleissä. Minua erityisen kiinnostaa
pelien hahmojen käyttäytymistä, joka on fiksua tai odottamatonta. Minua harmittaa liiallisen
ns. zombiemaiseen tekoälyyn, jossa mm. pelien viholliset ainoa tehtävä on löytää ja hyökää
pelaajaan, eikä reagoi paljonkaan ympäristöön ja tilanteen.

![GOAP_tekoäly_04_zombie_tekoäly](https://github.com/user-attachments/assets/b55330ab-1cad-468f-8d1b-69e1c715faa8)

Kuva 1: Zombimainen tekoäly. Tietokäsittelyn termein epämuodollinen tekoäly. Viholliset hyökävät suoraan pelaajaan. 

Viime aikoina olen pelannut kulttiklassikkoa Metro 2033, jossa vihollisten käyttäytyminen
on erikoisempi (ellei jopa epätäydellinen). Sen sijaan kuin hyökää suoraan pelaajiin, vihollinen
hyödyntää sekä ympäristöä että tilannetta. Esimerkiksi, vihollinen hyödyntää hänen takana olevaan
lampuvaloon, sillä se häikäsee pelaajan silmiin. Näin ollen pelaajalla on huomattavasti vaikea tähdätä
viholliseen.

![GOAP_tekoäly_04_fiksu_tekoäly](https://github.com/user-attachments/assets/4c72b219-ba85-4fc0-9234-7bc20a2d4966)


Kuva 2: Fiksumpi tekoäly. Tietokäsittelyn termein GOAP-tekoäly. Vihollinen hyödyntää ympäristöä parhaan mahdolliseen tulokseen.

Tarkoitukseni on tutkia ja oppia koodamaan kyseisen pelin hahmojen käyttäytymistä ja tekoälyä.
Tutkissaani eri lähteitä löysin yhden tekoälymallin, joka sopii parhaiten mainituun käyttäytmiseen.
Kyseessä on GOAP-malli (Goal-Oriented Action Planning), joka on tarpeeksi haastava kurssin lopputyölle.
Aion kehittää GOAP-mallin Godot pelimoottorissa C#-kielellä. Godot pelimoottori on minulle entuudesta tuttu
ja valmis asennettu koneelleni.

### 1.2 Rajaus

GOAP-malli on monien lähteiden mukaan todella vaativaa toteutettaa eikä löytyy paljon malliesimerkkiä Godotiin.
Jotta ehdin luomaan pienin toimiva tuote 20 tunnissa, ennen sunnuntaita 01.12.2024 deadlinea, minun täytyy rajoittaa
huomattavasti projektin skaalausta. 

1) Ensiksi, en luo pelaatavaa prototyypiä. Sen sijaan luon simulaatorin, jossa on yksi ei pelattava hahmo (NPC)
ja yksi kentä. Olkoon hahmo olla nimeltään Simon selkeyden vuoksi.


2) Toiseksi, koko simulaatori on kaksiuloiteinen (2D) jossa on yksinkertaisia symboleja (kuutio, kolmio, ympyrä, jne.).
3D ja realistiset tai sarjakuvamaisia hahmosuunnitelma on erittäin aikaavievää, eivätkä ole seminaarityön päätavoiteita.


3) 2D-kentään lisätään Simon-hahmon sekä yksi posiitivinen palaute että yksi negatiivinen palaute. Pelitermeissä tämä voi olla 
ruoka (posittiivinen) ja ansa (negatiivinen). Kentä voi olla tyyppiltään sokkelo kuten kuvassa 1.


4) Ei pelattava hahmo Simon yhdistetetään GOAP-tekoälyyn. 


5) Tarkistamme, miten Simon reagoi ympäristöön ja palauteisiin (ruokiin ja ansoihin).


6) Simon-hahmolla on kaksi yritystä (simon_lives == 1). Hän menettää yrityksen, jos hän osuu ansaan.
Hän saa lisää yrityksiä, kun kerää ruokia. Peli päätyy kahdella tavalla:
  * Simon-hahmo kerää kaikki ruokia (food_found >= 4).
  * Simon-hahmon yritysmäärä on negatiivinen (simon_lives < 0), 


7) Tavaoitteena on, että Simon-hahmo yrittää löytää nopeasti ja tehokkaasti ruoat. Samalla hän varoo ja peräntyy ansoista.


![Konsepti_GOAP_tekoälylle_v2](https://github.com/user-attachments/assets/dfe58c8a-2323-4d74-8fde-8fdb10bee715)
Kuva 1: Yksinkertainen piirrosluonnos kyseisestä simulaatorista.



### 1.2 Sisältö ja lopputulos


### 1.4 Käsitteet

GOAP -

Godot -

Minimum Viable Product (MVP)

Non Playable Character (NPC) - 



2.

## 3. Työkalut

### Godot-pelimoottori

#### Python vai C# tekoälylle?
## 5. Appenix A: Työpäiväkirja.

<details><summary><strong>Torstai 21.11.2024 Projektin käynnistys ja README.md kirjoitaminen</strong></summary>
  
---

<ins>Klo 14 - 16</ins>

1. Luoin repon ja README.md -tiedoston seminaariyölleni.
2. Kirjoitin sisältöä johdantoon.

---

</details>

<details><summary><strong>Perjantai 22.11.2024 Godotin pohja</strong></summary>
  
---

<ins>Klo 11 - 12; </ins>

1. Luoin uuden projektin Godotissa.

![GOAP-godot-01](https://github.com/user-attachments/assets/38344f8c-8940-454b-8a34-d831980a479b)

![GOAP_tekoäly_01_luon_uuden_godot](https://github.com/user-attachments/assets/1c4fc613-d2ba-4d06-b2ba-bd711b69f5c5)


Kuva 1 & 2: Uuden Godot projektin ikkuna. 

Valitsin Forward+ formaatin, sillä se hallinnoi monimutkaisimpia ratkaisuja kuten kuvassa 1 ja 2
näytää. Valettavasti tämä tarkoittaa, että renderöinti ja koodin kokoaminen voi kestää minuuttia.

Laitan tietysti version hallinta Gitiin, sillä julkaisemme koodiprojektin Githubiin.

Tallennan projektin kloonatuun Ohjelmistokehityksen-teknologiat-s2024-GOAP-tekoaly-Godotissa
-hakemistoon Githubista.

![GOAP_tekoäly_02_uuden_godot_pushattu_Githubiin](https://github.com/user-attachments/assets/298c1fcd-9ccd-476c-a7ef-71e484f2c9f2)

![GOAP_tekoäly_03_uuden_godot_pushattu_Githubissa](https://github.com/user-attachments/assets/fd9b9efc-74c8-4a74-8edf-3c9a20d468c1)


Kuva 3 & 4: Godot projektin julkaisu Githubiin.

---

</details>

<details>
<summary><strong>Perjantai 29.11.2024 Godotin alku</strong></summary> 
---
<ins>Klo 18-21</ins>
Tarvitsen opastusta yksinkertaisen sokkelon tekemiseen.


Huomautus, että minulla on Godot Engine versio 4.3 asennettu Steamiin.

![GOAP_tekoäly_29112024_01_Godot_versio](https://github.com/user-attachments/assets/a98b7cf0-ef09-4e9b-b35b-9a0fe6587101)

Kuva 5: Godotin asennettu 4.3 -versio Steamissa.


Tällöin päivitetty Godotin dokumentaatiot viralliselta sivustolta voi olla hyötyä.
Virallinen sivusto on https://docs.godotengine.org/en/stable/getting_started/first_2d_game/index.html .

![image](https://github.com/user-attachments/assets/fa6f3e69-ffdf-4245-adc8-c48af83541e3)

Kuva 6: Godotin dokumentaatiot viralliselta sivustolta.

Dokumentaatiosta löytyi mm. esivaatimuksia liityen C#-kielen käyttö. Koska Godot engine 4.3
-versio käyttää oletuksena omaa kieltä, GDScript, joudun manuaalisesti konfiguroimaan C#-kielen
Godotiin. Tarkka linkki dokumentaatioon on https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/c_sharp_basics.html .


![image](https://github.com/user-attachments/assets/b9d6567e-ef6b-474c-ba17-f698ccc78529)


Kuva 7: Godotin virallisesti dokumentaatiot C#-kielen käyttöönottoon.

Vaatimus 1) Varmista että sinulla on Visual Studio Code ja sen C#-lisäys asennettu.
-> Olen tehnyt.

![image](https://github.com/user-attachments/assets/a5e9a7ca-8c0f-40d7-be11-e0d0b0a6dcb3)

Kuva 8: Visual Studio Code ja C#-lisäys asennettu.

Vaatimus 2) Muutaa Editor > Editor Setting > Dotnet > External Editor kohdassa Visual Studio Code.

Valettavasti minun Godot Engine 4.3-version Steamissa ei löytynyt kyseistä konfigurointia.

![GOAP-godot-02](https://github.com/user-attachments/assets/9455814f-6f0c-4316-9232-7aace120b050)

Kuva 9: Puuttava Dotnet konfigurointi.

Onneksi Visual Studio Code löytyy **C# Tools for Godot** -lisäys Ignacio Roldán Etcheverry,
jos haluaa debuggata Godot C# -projekteja Visual Studio Codessa. Viimeisin päivitys oli 31.01.2023.

![image](https://github.com/user-attachments/assets/c75e741b-ea43-4e56-864d-c3c68e620d7b)

![image](https://github.com/user-attachments/assets/7241fd77-b537-4ed1-8a7e-1c06c1e7f41c)

Kuva 10: C# Tools for Godot -lisäys Visual Studio Codessa.

Muita opasteita Godot Engine 4.3-version C#-kielen konfigurointiin löytyy Youtubesta käyttäjältä The SolarString.
Hänen videonsa julkaistiin 12 Marraskuuta 2024, joten hänen opastaa nimeomaan nykyisessä Godot Engine 4.3-versiossa.

![image](https://github.com/user-attachments/assets/23d05586-6cc7-4d64-9f12-3b8fdb695bd3)

Kuva 11: Youtuben TheSolarString -käyttäjän opasvideo C#-konfigurointiin Godot Engine 4.3-versiossa.

Videosta huomaan, että TheSolarString -käyttäjä on asentanut **Godot Engine -.NET 4.3** -versiota,
johon kuuluu edellisessä dokumentaatiossa mainitun Dotnet -konfigurointi.

![image](https://github.com/user-attachments/assets/336e20e3-0d88-464e-b7db-c60370d58fa6)

Kuva 12: TheSolarString esittää Dotnet -asetusta Editor Settings:issä, aikaleima 3:07.

Itse käytän **Godot Engine 4.3 Steam** versiota. Jos noudan videon mukaan kaikki vaiheet,
joutuisin asentamaan erikseen **Godot Engine -.NET 4.3** ja uusimman **.NET 8.0 SDK** -version
koneelleni. Varmistin terminaalistani, että minulla on tällä hetkellä .NET 7.0 -version
asennettuna.

![image](https://github.com/user-attachments/assets/40c00657-7fb7-428a-859f-56d511734f0f)

Kuva 13: .NET -versio tarkistus terminaalissa.

Miksi haluan mielummin käyttä Steamin version kuin Godot Engine -.NET
on *Steamin automaatinen versiopäivitys*. Aiemmassa Godot 3 -versiossa joutui
aina päivitämään kaikki uudemmat versiot (mukaan lukien .NET) **manuaalisesti**. Steamin versio
on helpotaa suuresti päivityksessä.

Tarkistessaan muita lähteitä, kuten Steamin foruumista, valettavasti Godot Engine 4.3 Steam -versio *ei tue* C#-kieltä ollenkaan.
Kyseinen foruumin keskustelu löytyy linkistä https://steamcommunity.com/app/404790/discussions/0/4133808627038364598/ .
Se näkyy myös Godot Engine 4.3 Steam -versiossa, kun yritää luodaa uuden C#-skriptin mutta ominaisuutta ei löydy. Muun muassa, Project > Tools ei löydy C# > Create C# solution välikohtaa eikä uuden skriptissä voi valita C# -kielen.


![image](https://github.com/user-attachments/assets/5b831352-7d87-4718-8688-44017ad3d36b)

![GOAP-godot-03](https://github.com/user-attachments/assets/0b4e87bd-7c38-4fd8-8b6c-80f09ebfc038)


Kuva 14: Foruumin keskustelu Godot Engine 4.3 Steamin C#-tuesta ja demovideo sen puutevuudesta.

Hämmentävää, sillä muistin Godot Engine 4 -version julkaisussa, että C#-kieli olisi vihdoin
asennettu valmiiksi kaikki Godot Engine 4 -versioihin, mukaan lukien Steamin versioon.
Näköjään muistin väärin ja joudun asentamaan viralliselta Godot-sivustolta
**Godot Engine 4.3 -.NET** että uusimman .NET SDK 8 -version (*olipa suuri pettymys >:(*).

Asennan kyseisen Godot Engine 4.3 -.NET -version TheSolarString-käyttäjän videon mukaisesti.

![image](https://github.com/user-attachments/assets/1c76ede9-9431-4b60-8207-c1064ff9f9da)

Kuva 14: Godot Engine 4.3 -.NET -version (15.8.2024) julkaisu sivusto: https://godotengine.org/download/windows/ .

![image](https://github.com/user-attachments/assets/f24b33f4-993b-46b3-a772-67602e4b387c)

Kuva 15: .NET SDK 8 -version julkaisu sivusto: https://dotnet.microsoft.com/en-us/download/dotnet/8.0 .

Olen nyt asentanut uudemmat versiot koneelleni.

![image](https://github.com/user-attachments/assets/152e16d5-94e6-404e-b9e2-a6eee632e4bb)

Kuva 16: Godot Engine 4.3 -.NET -versio Godot-hakemistossani koneellani.

![image](https://github.com/user-attachments/assets/4fd987db-f1b3-4c75-974b-6387fe83d40a)

Kuva 17: .NET 8.0.404 -versio löytyi terminaalista kommennolla *dotnet --list-sdks*. 

TheSolarString-käyttäjä suosittelee asentaa myös Microsoftin virallinen **C# Dev Kit** -lisäyksen
Visual Studio Codesta. Siinä sisältyy tavallisen C# -lisäyksen ohella muita tarpellisia ominaisuuksia.

![image](https://github.com/user-attachments/assets/c2e4a303-9a5f-456a-8c22-6aaad9876d8f)

Kuva 18: C# Dev Kit -lisäys Visual Studio Code:iin asennettu.

Avaan Godot Engine 4.3 -.NET -ohjelmiston, joka on nimeltään **Godot_v4.3-stable_mono_win64** Godot-hakemistossani (katso kuva 16).
Luon sitten uudelleen saman projektin Git -repositoriin (poistin tietysti vanhan Steam-version pois).

![GOAP-godot-04](https://github.com/user-attachments/assets/aad05f6c-ef03-40e6-a834-1a955ef78f13)


Kuva 19: Godot projektin jälleenluonti Git -repositoriin.

Pari huomautuksia kuvaan 19.

HUOM.1) Projekti tallennettu väärään hakemistoon. Siirsin projektin 
oikeaan Git -hakemistoon kuvanahoituksen jälkeen.

HUOM.2) Jälleen nimensin projektin edellisestä "goap-ohjelmistokehityksen-teknologiat" uuteen "goap-godot-ohke" (ohke tulee lyhenteestä
Ohjelmistokehityksen teknologiat -kurssin lyhenteestä). Syynä liityy enimmäismäärän merkkejä, joita Git Bash sallii projektin julkaisussa.
Olen kohdistunut hyvin usein ongelmaan, sillä sekä väylät että projektin nimeissä käytän todella pitkiä nimejä. Vältäkseen ongelmasta, käytin siksi
uuden, lyhemmän nimen.

Pushasin uuden projektin Git -repositoriin Githubiin.

![image](https://github.com/user-attachments/assets/83135c87-9f58-4fb0-a038-0c55b722a3f4)

Kuva 20: Päivitetty pushaus Githubissa.

</details>

<details>
<summary><strong>Lauantai 30.11.2024 Godotin jatko</strong></summary> 
---
<ins>Klo 11:30 - 12:30 </ins>

TheSolarString -käyttäjä ehdottaa ensiksi luoda ja tallenna kaksiuloitteisen **main** -tiedoston ja **Scenes** -hakemiston.

![GOAP-godot-05](https://github.com/user-attachments/assets/961af313-5822-4672-bf8e-12b166f9d49f)

Kuva 21: Main -tiedoston ja Scenes -hakemiston luominen. 
 
Konfiguroidaan Godot Engine 4.3 -.NET -moottorille Visual Studio Code ulkoisena editorina, 
muokamalla Editor Settings > Dotnet > External Editor "Disabled" asetuksesta "Visual Studio Code" asetukseen.

Kuva 22: Valitsemme Visual Studio Code:n ulkoiseksi editoriksi Godotille Settings > Dotnet > External Editor -asetuksesta.

Konfiguroidaan Main -tiedosto C#-kieleksi, painamalla Main -tiedoston hiiren oikealla, sitten valitse Language: C# ja lopuksi Create.

![GOAP-godot-07](https://github.com/user-attachments/assets/13a6cfae-7010-4561-9d12-c1820c909c36)

Kuva 23: Muutaa Main -tiedosto C#-kieleksi.

Lopuksi painetaan yllä oikealla olevaan "Build project" ikoniin (vasaran symbooli),
jolloin Godot rakentaa täysin C# ja .NET -projektin. Tässä voi kestää useita minuutteja.

![GOAP-godot-08](https://github.com/user-attachments/assets/9b0d7c4a-3cdf-43a2-845f-cb3e1d528032)

Kuva 24: "Build project" -käynnistys.

Nyt minulla on yhdistetty Visual Studio Code Godotiin, jolloin Godot pystyy käytämään C#-kieltä.
TheSolarString -käyttäjä käy opasvideossaan vielä viimeiset konfiguroinnit, jolloin Visual Studio Codessa
voidaan debuggata Godot-koodia kuten GD.Print"Hello!". Suosittelen tarkistamaan TheSolarStringin opasvideota
https://www.youtube.com/watch?v=QetDIxDorFI , aikaleimasta 3:30 -5:40 tarkempaa ohjausta. 

Seuratuaan TheSolarStringin opasvideota, minulla on vaaditut json -tiedostot .NET debuggaukseen,
kuten tasks.json ja launch.json -tiedostot.

![image](https://github.com/user-attachments/assets/e47136e1-da09-4496-bdf2-6c17c80efbb7)

![image](https://github.com/user-attachments/assets/1b846adf-422d-4fbf-8c7f-0eb1ec5f5717)

Kuva 25: tasks.json ja launch.json -tiedostot.

Ajetuaan projektia Godot Engine 4.3 -.NET -moottorissa (eli "Run Project"), tulee onnistunut tulostusviesti 
Godotin omaan terminaalin (ts. "Hello"-viestin).

![GOAP_tekoäly_30112024_01](https://github.com/user-attachments/assets/c0dc21a4-9a4c-4d58-bb04-6a99d890eefc)

Kuva 26: Onnistunut "Hello"-viestin tulostus Godotin terminaalissa.

Nyt olemme täysin varmoja, että Godot Engine 4.3 -.NET -moottori ja Visual Studio Code -editori ovat
suurin osin yhdistetty toisiaan. Tämä tarkoittaa, että voin koodata C#-skriptejä Visual Studio Codessa, jotka
lähetetään ja pyöritetään Godot-moottorissa.


<ins>Klo 18:30 - 20:30 </ins>

Nyt pitäisi koodata yksinkertainen sokkelo, jossa on vähintään yksi ei pelattava hahmo.
Tuli mieleen Pac-man peli, jossa haamut jahtavat keltaista Pac-mania sokkelossa.

Ensiksi yritin etsiä Pac man esimerkkejä Godot C#-kielellä. Haulla löytyi
mm. "How to make Pacman in Godot 4 (Complete Tutorial)" -opasvideon Youtubesta, käyttäjältä
Cyberpotato: https://www.youtube.com/watch?v=CncJvOEM3OA. Hänellä on oma Github repositori
projektille: https://github.com/wojciech-bilicki/Pacman_Tutorial , käyttäjänimellä wojciech-bilicki.

![image](https://github.com/user-attachments/assets/f9f2ef39-c68a-4534-ab4a-5129ef780ba3)

Kuva 27: Cyberpotato-käyttäjän opasvideo Pac-man peliluontiin.

Tarkistessaan hänen Github repositoria (https://github.com/wojciech-bilicki/Pacman_Tutorial), 
hän on koodanut peliä GDScriptiä (Godot-mootorin oma kieli) mikä
ei sovi minulle C#-projektelleni. Siinä suhteessa hänellä kiinnostava artikkeli
liityen pelin hahmuujen tekoälyn suunnittelussa: https://pacman.fandom.com/wiki/Maze_Ghost_AI_Behaviors .

Siitä huolimatta, Cyberpotaton opasvideossa (https://www.youtube.com/watch?v=CncJvOEM3OA) on hyvä 
pohja hahmojen ja sokkelotason tuominenja konfigurointi Godotiin.

A) Sokkelon luominen, aikaleima 3:52-

Cyberpotaton Github repositorissa Pacman_tutorial/Assets/Map -hakemistossa löytyy alkuperäiset
Pac-manin kentiä origmaps_2x.png-tiedostossa. Lataan sen ja leikaan palaksi Ms. Pac-Man(3)
- ruudukkokentän. Pidän sen värivalinnasta (oranssi-musta) enemmän kuin Cyberpotaton mallikentästä
(sini-musta).

![image](https://github.com/user-attachments/assets/36fdad92-e404-4f50-913a-5d6968da35f4)

Kuva 28: Ms. Pac-Man (3) -kentä

Kuvakäsittelyn avulla, mm. Clip Studio Paint, sain tehtyä noin 12 ruudukkoa sokkelolle.
Kyseinen kuvakäsittely helpottaa suuresti ruudukon tekemiseen, koska siinä on peili-ominaisuus,
mikä kääntää mikä tahansa palikan vaakasuoraan ja pystysuoraan. Joten tarvitsin oikeasta
työskennellä kolme itsenäisiä palikkaa, joista tallennan neljä erikulmaisia kuvaa.

![image](https://github.com/user-attachments/assets/e79b69c3-9870-425b-8c8d-61a557df99cd) ![image](https://github.com/user-attachments/assets/26c1e9c1-e19a-44b9-b9d3-b6d17570d277) ![image](https://github.com/user-attachments/assets/c16ad833-fbcc-406d-a5d1-28380c5ffa3e) ![image](https://github.com/user-attachments/assets/2777e737-c8f5-4dfa-a3a9-d4c52f67559a)

Kuva 29: Yhden palikkan ja niiden kolme käännettyjä kulmakuvia esimerkkejä.

Samalla tein ei-pelattavalle Simon hahmolle, ruoalle ja ansalle omia kuvioita.

![image](https://github.com/user-attachments/assets/68a49849-5267-47cc-a0d2-dd940e2f5f8d)
 ![image](https://github.com/user-attachments/assets/2f0c0b17-b111-41dd-827c-6fa789e6f480)
 ![image](https://github.com/user-attachments/assets/4c2cad7b-e647-49ca-81ff-3a792e621fcc)


Kuva 30: Simon hahmo, ruoka ja ansa -kuviot.

Kaikki kuviot ovat mittasuhteena 18 x 18 pikseliä. Vien kaikki kuviot Godot projektin
Assets -hakemistoon.

![image](https://github.com/user-attachments/assets/3380d8bf-1909-4a85-bcd1-ddd3536a74c3)

Kuva 31: Kaikki tarpeelliset kuviot tuottu Assets -hakemistoon. Käytin Drag & Drop -tapa hiirellä
tiedoston viemiseen.



Koska Godot C#-projektien työskentely on vielä "epätavallista" (tai vähemmän suosittua
kuin GDScripti) Godot-yhteisössä, etsin seuraavasti "Pac-man tutorial with C#" hakuja.



</details>



<details>
<summary><strong>Sunnuntai 01.12.2024 Godotin loppu</strong></summary> 
---
<ins>Klo </ins>
Tarvitsen opastusta yksinkertaisen sokkelon tekemiseen. 
 
</details>

### Lopullinen työaikataulukko

* 21.11.2024: 2 tuntia.
* 22.11.2024: 1 tuntia.
* 29.11.2024: 3 tuntia.
* 30.11.2024: 1 + 2 + tuntia.
* 01.12.2024: tuntia.

Yhteensä:

## Lähteet
