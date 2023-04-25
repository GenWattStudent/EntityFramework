## Zarządzanie Rekrutacją na studia

Zdjęcie schematu bazy danych:

![Zdjęcie schematu bazy danych](./assets/E2%20BD.png)

## Opis

Celem systemu rekrutacji na studia jest umożliwienie zarządzania procesem rekrutacyjnym oraz udostępnienie informacji związanych z kandydatami, ich dokumentami oraz wynikami egzaminów.

Wymagania:

- możliwość elektronicznego przesyłania dokumentów przez kandydatów,

- automatyczne sprawdzanie poprawności danych i kompletności dokumentów,

- przetwarzanie danych zgodne z wymaganiami RODO,

- możliwość weryfikacji dokumentów przez pracowników uczelni,

- system powinien być dostępny dla kandydatów i pracowników uczelni przez całą dobę,

- system powinien zapewnić ochronę danych osobowych i być odporny na ataki z zewnątrz.

Obszary krytyczne:

- poprawność i kompletność danych wprowadzanych przez kandydatów,

- terminowość przetwarzania danych i dokonywanie weryfikacji dokumentów,

- dostępność systemu dla kandydatów i pracowników uczelni,

- bezpieczeństwo przetwarzanych danych.

Ocena wartości:

- koszt implementacji i utrzymania systemu,

- łatwość obsługi i użytkowania dla kandydatów i pracowników uczelni,

- elastyczność i skalowalność systemu,

- szybkość przetwarzania danych i realizacji procesu rekrutacji,

- bezpieczeństwo i ochronę danych osobowych,

- zgodność z obowiązującymi przepisami i standardami.

Oszacowanie ryzyka:

- ryzyko naruszenia danych osobowych,

- ryzyko niedostępności systemu w czasie rekrutacji,

- ryzyko popełnienia błędów w procesie rekrutacji,

- ryzyko utraty danych i informacji.

W aplikacji mamy tabele:

- `Użytownicy` - tabela z użytkownikami
- `Kandydaci` - tabela z kandydatami
- `Kierunki` - tabela z kierunkami
- `Pracownicy` - tabela z pracownikami
- `Dokumenty` - tabela z dokumentami
- `Adresy` - tabela z adresami
- `Egzaminy` - tabela z egzaminami
- `Płatności` - tabela z płatnościami
