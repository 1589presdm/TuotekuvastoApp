# TuotekuvastoApp

## Keskeiset osat koodista

### 1. `HomeController.cs`
`HomeController` sisältää sovelluksen logiikan, joka liittyy tuotteiden hallintaan. Metodi `Product` lataa tuotteiden tiedot tiedostosta `products.json` ja lähettää ne `Product.cshtml`-näkymään. Metodi `GetProducts` lukee JSON-tiedoston ja muuntaa sen `Product`-olioiksi käyttämällä `Newtonsoft.Json`-kirjastoa.

### 2. `products.json`
`products.json` sijaitsee `wwwroot`-kansiossa ja sisältää tuotteiden tiedot JSON-muodossa. Tiedosto toimii tietolähteenä sovellukselle ja sisältää tuotteiden nimen (`name`), hinnan (`price`), kuvauksen (`description`) ja kuvalinkin (`image`).

### 3. `Product.cs`
`Product.cs` on malli, joka kuvaa tuotetta. Se sisältää ominaisuuksia, kuten `Name`, `Price`, `Description` ja `Image`, sekä laskennallisia ominaisuuksia, kuten `FormattedName` ja `FormattedPrice`, jotka auttavat tietojen näyttämisessä oikein.

### 4. `Product.cshtml`
`Product.cshtml` on Razor-näkymä, joka vastaanottaa `Product`-metodin kautta saadut tuotetiedot ja näyttää ne käyttäjälle korttinäkymänä. CSS ja JavaScript vastaavat näkymän ulkoasun muotoilusta.

## Miten osat kommunikoivat ja miten tiedot haetaan ja näytetään

1. **Tietojen lataus**: `Product`-metodi kutsuu `GetProducts`-metodia, joka lukee `products.json`-tiedoston ja muuntaa sen tuotetiedoiksi.
2. **Tietojen siirto**: `Product`-metodi palauttaa tuotetiedot `Product.cshtml`-näkymään.
3. **Tietojen näyttäminen**: `Product.cshtml` käsittelee tuotetiedot ja näyttää ne kortteina, joista näkyvät nimi, kuva, kuvaus ja hinta.