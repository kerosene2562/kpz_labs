# Structural Patterns (Lab 3)

## Pattern: Adapter

**Purpose:** Allows combining a logger with file writing functionality.

### Structure:
- `ILogger.cs` — logger interface: `Log()`, `Error()`, `Warn()`
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
- Render interface: `Renderer.cs`
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

## Pattern: Composite (LightHTML)

**Purpose:** Builds an HTML tree from nodes.

### Structure:
- `HTMLElement.cs` — base node
- `LightHTML.cs` — text node
- `MemoryMonitor.cs`, `MemorySizeConvertor.cs` — memory analysis utilities

---

## Pattern: Flyweight

**Purpose:** Optimizes memory usage by sharing common properties.

### Structure:
- `HTMLElement.cs`, `LightHTML.cs` — HTML nodes
- `MemoryMonitor.cs`, `MemorySizeConvertor.cs` — memory monitoring tools

---
