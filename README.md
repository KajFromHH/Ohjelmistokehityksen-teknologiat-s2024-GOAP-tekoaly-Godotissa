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
<ins>Klo 18-23</ins>
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



Valettavasti sivustolla ei ollut opasteet yksinkertaiseen sokkelon tekemiseen C# -kielellä.



 
</details>

<details>
<summary><strong>Perjantai 29.11.2024 Godotin jatko</strong></summary> 
---
<ins>Klo </ins>
Tarvitsen opastusta yksinkertaisen sokkelon tekemiseen. 
 
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
* 28.11.2024:  tuntia.

Yhteensä:

## Lähteet
