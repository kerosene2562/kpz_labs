# Structural Patterns (Lab 3)

## Pattern: Adapter

**Purpose:** Allows combining a logger with file writing functionality.

### Structure:
- `Logger.cs` — logger that outputs messages to the console
- `FileWriter.cs` — writes messages to a file
- `FileWriterAdapter.cs` — adapter to use `FileWriter` as a logger

---

## Pattern: Decorator

**Purpose:** Dynamically adds new properties to hero classes.

### Structure:
- `IHero.cs` — hero interface: `Info()`, `GetPower()`
- Heroes: `Mage.cs`, `Paladin.cs`, `Warrior.cs`
- Items/Decorators: `Armor.cs`, `Artifact.cs`, `Weapon.cs`
- `HeroDecorator.cs` — base decorator class

---

## Pattern: Bridge

**Purpose:** Separates abstraction (shapes) from implementation (rendering).

### Structure:
- Render interface: `IRenderer.cs`
- Implementations: `RasterRenderer.cs`, `VectorRenderer.cs`
- Abstraction: `Shape.cs`
- Shapes: `Circle.cs`, `Square.cs`, `Triangle.cs`

---

## Pattern: Proxy

**Purpose:** Controls access to text files and provides logging functionality.

### Structure:
- `SmartTextReader.cs` — basic file reader
- `SmartTextChecker.cs` — adds logging to file reading
- `SmartTextReaderLocker.cs` — restricts file access using regular expressions

---

## Pattern: Composite

**Purpose:** Builds an HTML tree from nodes.

### Structure:
- `LightNode.cs` — An abstract class that defines the basic behavior for nodes in LightHTML
- `LightTextNode.cs` — Represents a text node that contains only text and cannot have child elements
- `LightElementNode.cs` — Can contain other nodes, and also has attributes that define its behavior

---

## Pattern: Flyweight

**Purpose:** Optimizes memory usage by sharing common properties.

### Structure:
- `HTMLElement.cs`, `LightHTML.cs` — HTML nodes
- `MemoryMonitor.cs`, `MemorySizeConvertor.cs` — memory monitoring tools

---
