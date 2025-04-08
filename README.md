# GameObjectMapper

This project shows different ways to map (convert) objects in .NET applications, using examples from game development:

- **AutoMapper** *(with a notice about future payments)*
- **Mapster** *(a free and fast alternative to AutoMapper)*
- **Manual implementations**:
  - Explicit Operator
  - Implicit Operator
  - Extension Methods

## ⚠️ Important: AutoMapper will become paid!

AutoMapper announced that it will soon have a paid version. This project shows practical, free alternatives.

---

## 📁 Project Structure

Your project is well organized by separating each mapping strategy into its own namespace/folder. Here is the updated folder structure based on the current organization:

```plaintext
GameObjectMapper
│
├── Dtos
│   └── CharacterDTO.cs
│
├── Enum
│   └── CharacterClass.cs
│
├── Mappers
│   ├── AutoMapperExemple
│   │   ├── AutoMapperProfile.cs
│   │   └── Character.cs
│   ├── ExplicitOperatorExemple
│   │   └── Character.cs
│   ├── ExtensionMethodExemple
│   │   └── CharacterMappingExtensions.cs
│   ├── ImplicitOperatorExemple
│   │   └── Character.cs
│   └── MapsterExample
│       └── MapsterConfig.cs
│
├── Models
│   └── Character.cs
│
├── Program.cs
├── README.md
└── LICENSE.txt
```

---

## 🚀 How to run the examples

Each approach is demonstrated in a single `Program.cs` file. To run it:

```bash
dotnet run
```

---

## 🎮 Study examples

The examples in this project use a real-world game context. You will find entities like `Character`, `CharacterClass`, and `CharacterDTO`, mapped using different techniques. These are helpful for understanding object mapping in real scenarios.

---

## 📊 Comparison Table

| Method               | Type             | Performance | Configuration Required | Readability | Flexibility |
|----------------------|------------------|-------------|------------------------|-------------|-------------|
| **AutoMapper**       | Library           | Medium      | Yes                    | High        | High        |
| **Mapster**          | Library           | High        | Optional               | High        | Medium      |
| **Explicit Operator**| Manual            | High        | No                     | Medium      | Medium      |
| **Implicit Operator**| Manual            | High        | No                     | High        | Low         |
| **Extension Method** | Manual/Reusable   | High        | No                     | High        | High        |

---

## 📚 References

- [AutoMapper](https://automapper.org/)
- [Mapster](https://github.com/MapsterMapper/Mapster)
- [Microsoft Docs - Conversion Operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators)
- [Microsoft Docs - Extension Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)

---

## 💡 Recommendations

- Use **Mapster** for a simple and high-performance solution.
- Use **AutoMapper** if you already have it in your stack and need advanced mapping configurations.
- Choose **manual options** (explicit/implicit operators or extensions) for more control and performance.

---

## 🔖 License

This project uses the MIT license.

