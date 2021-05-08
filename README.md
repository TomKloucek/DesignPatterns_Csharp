# Návrhové vzory

Slouží k vysvětlení a ukázce návrhových vzorů a dále jako příprava na maturitu.

## Behavioral Design Patterns
Zajímají se o chování systému. Mohou být založeny na třídách nebo objektech. Využívají především dědičnosti a rozhraní. Je řešena spolupráce mezi objekty.

### Iterator
Hlavní myšlenkou vzoru Iterátor je umožnit přístup a procházení seznamu požadovaným způsobem. Všechny tyto funkce budou umístěny v objektu iterátoru. Třída iterátor definuje rozhraní pro přístup k prvkům seznamu. Objekt iterátoru je také zodpovědný za sledování aktuálního prvku a toho, které prvky již byly projity.

### Command
Zapouzdřuje operaci a její parametry do objektu tak, aby šla kdykoliv později zavolat. Potřebné informace většinou zahrnují typ operace, názvy parametrů a jejich hodnoty.

### Strategy
Slouží k vyměňování algoritmů za běhu programu. Buď na žádost klienta, nebo na nějaký vnější děj např. víkendová sleva reaguje na víkend.

## Creational Design Patterns
Řeší problémy související s vytvářením objektů v systému. Například zajištění správného počtu vytvořených objektů. Většinou se jedná o dynamická rozhodnutí učiněná za běhu programu.

### Object Pool
Použijeme potřebujeme-li omezit počet vytvářených instancí, jejichž výroba je časově náročná. Pool upřednostňuje recyklaci objektů před vytvářením nových instancí.

### Singleton
Využiejeme ho když je potřeba zajistit, aby v celém programu existovala pouze jedinán instance určité třídy. Také poskytuje globální přístupový bod k instanci.

### Factory
Je metoda jejímž účelem je vytvořit novou instanci nějakého objektu a vytvořenou instanci vrátit. Druh objketu a jeho vlastnosti jsou parametry, které zadáme metodě.

## Structural Design Patterns
Slouží k uspořádání jednotlivých komponent a tříd v systému. Snahou je zpřehlednit systém.

### Decorator
Používá se pro dynamické přidání či změnu funkčnosti bez nutnosti jeho změny či použití dědičnosti.

### Proxy
Nahradí objekt sám sebou a navenek bude působit a zároveň může přidat jiné funkčnosti. Například logování.

### Flyweight
Hodně zjednodušeně Flyweight je objekt který umožňuje vměstnat více objektů do dostupné paměti RAM sdílením společných částí stavu mezi více objekty namísto uchovávání všech dat v každém objektu.
