# Aplicatii-CSharp

Colectie de aplicatii C# de consola realizate in Visual Studio, ca exercitii pentru
lucrul cu variabile, tablouri, clase, liste si meniuri.

## Tehnologii

- C# / .NET 8
- Visual Studio
- Git si GitHub

## Proiecte

| Proiect | Scop |
|---|---|
| [DreptunghiApp](DreptunghiApp) | Calculeaza aria si perimetrul unui dreptunghi; respinge valorile negative sau zero |
| [CatalogNote](CatalogNote) | Calculeaza media a sase note si decide daca studentul a promovat |
| [ProduseApp](ProduseApp) | Afiseaza o lista de trei produse si totalul preturilor |
| [MeniuAplicatie](MeniuAplicatie) | Prototip de meniu pentru o viitoare aplicatie desktop, cu optiunea 4. Iesire |

## Rulare

1. Deschideti folderul proiectului dorit (de exemplu `DreptunghiApp`) in Visual Studio,
   prin fisierul `.csproj`.
2. Apasati **Ctrl+F5** (Start Without Debugging).

Din linia de comanda:

```
dotnet run --project DreptunghiApp
```

## Exemple de executie

### DreptunghiApp

```
Lungime: 8
Latime: 5
Aria = 40
Perimetrul = 26
```

Test cu 12 si 4:

```
Lungime: 12
Latime: 4
Aria = 48
Perimetrul = 32
```

Validare valori negative:

```
Lungime: -3
Latime: 4
Eroare: lungimea si latimea trebuie sa fie pozitive!
```

### CatalogNote

```
Note: 8, 9, 10, 7, 6, 9
Media: 8,17
Promovat
```

### ProduseApp

```
Caiet: 15 lei
Pix: 8 lei
Rigla: 5 lei
Total: 28 lei
```

### MeniuAplicatie

```
APLICATIE GESTIUNE
1. Clienti
2. Programari
3. Rapoarte
4. Iesire
Alegeti optiunea: 2
Modul Programari
```

## Autor

Student - grupa ______
