# Contribution Guide

&nbsp;
All contributions that follow the conventions below will be welcome.

## Nomenclature

- Local variables: `camelCase`
- Classes, attributes, methods and class files: `PascalCase`
- Batch files, SQL scripts, stored procedures, views, functions, tables, columns and database name: `snake_case`

## Style

### Language

- The project files and structure must be in English.
- The code must be in English.
- Database tables and attributes must be in English.
- Comments must be in Spanish.

### Comments

- Comments must be in Spanish.
- Comments that refer to a single line of code must be inline, placed to the right of the line in question.
- Comments referring to a block of code should be placed above the block, separated from the code by a blank line before and after the comment.

### Blank Lines, Indentation, and Spaces

- Use 4-space indentation.
- Leave a space after a comma or before a parenthesis, unless it's the parenthesis of a function, which should be immediately adjacent to the function name.
- Always leave a blank line before and after a flow control structure (if, for, while, etc.).
- Leave a blank line after a closing brace, unless it's between successive closing braces or before `else` blocks.
- Do not leave blank lines or spaces after an opening brace or before a closing brace.

### Braces

- Align all braces with their respective block braces.
- Lines containing braces should contain only braces.
- Use braces even in single-line `if` blocks.

## Database

- Due to limitations on free servers for deploying the project, the use of triggers is not allowed.

## Extensions

### Prettier SQL VSCode

&nbsp;
Install the [Prettier SQL VSCode](https://marketplace.visualstudio.com/items?itemName=inferrinizzard.prettier-sql-vscode) extension for Visual Studio Code. Before each commit involving `.sql` files, open the file in VS Code, right-click on the code, and then click `Format Document`. (Any SQL code editor from any database management system can be used, but the code should be formatted with Prettier SQL VSCode afterward.)

## UX/UI

### Paleta de colores

| Nombre | Código Hexadecimal | Vista previa | Uso sugerido |
|-|-|-|-|
| **Blanco Puro**  | `#FFFFFF` | ![#FFFFFF](https://via.placeholder.com/20/FFFFFF?text=+) | Fondo principal, textos claros sobre fondos oscuros. |
| **Gris Claro** | `#F2F2F2` | ![#F2F2F2](https://via.placeholder.com/20/F2F2F2?text=+) | Fondo secundario, bordes suaves. |
| **Gris Suave** | `#E5E5E5` | ![#E5E5E5](https://via.placeholder.com/20/E5E5E5?text=+) | Separadores, tarjetas, elementos secundarios. |
| **Gris Medio** | `#CCCCCC` | ![#CCCCCC](https://via.placeholder.com/20/CCCCCC?text=+) | Contornos, detalles sutiles. |
| **Gris Oscuro** | `#808080` | ![#808080](https://via.placeholder.com/20/808080?text=+) | Textos secundarios, botones inactivos. |
| **Negro Suave** | `#333333` | ![#333333](https://via.placeholder.com/20/333333?text=+) | Textos principales, botones sobre fondos claros. |
| **Negro Puro** | `#000000` | ![#000000](https://via.placeholder.com/20/000000?text=+) | Fondo oscuro, elementos destacados en blanco. |
