# Desafío logica de netcore

## Descripción

El siguiente desafío tiene como objetivo la resolucion en base a la logica del desarrollador.

## Preguntas

### 1. Simplificación de Fracciones

Crear una función que devuelva una versión simplificada de una fracción.

#### Ejemplos

- `Simplificar("4/6")` debe retornar `"2/3"`.
- `Simplificar("10/11")` debe retornar `"10/11"`.
- `Simplificar("100/400")` debe retornar `"1/4"`.

**Notas:** Una fracción simplificada no tiene divisores comunes mínimos (excepto 1) entre el numerador y el denominador.

### 2. Validar Nombres

Crear una función que valide nombres según las siguientes definiciones y reglas.

#### Definiciones

- El término ingresado pueden ser iniciales o palabras completas.
- Una inicial es solo un carácter más un punto.
- Una palabra se comprende de 2 o más caracteres sin punto.

#### Reglas

- Las iniciales como las palabras completas deben estar capitalizadas.
- Las iniciales deben terminar en punto (`.`).
- Solo habrán 2 o 3 términos en el ingreso.
- Si se ingresan dos nombres y un apellido, los dos primeros pueden ser iniciales o solo el segundo. Nunca puede ser una inicial el primer nombre y no el segundo.
- El apellido siempre debe ser una palabra completa.

#### Ejemplos

- `ValidName("E. Poe") ➞ true`
- `ValidName("E. A. Poe") ➞ true`
- `ValidName("Edgard Allan Poe") ➞ true`
- `ValidName("Edgard") ➞ false`
- `ValidName("e. Poe") ➞ false`
- `ValidName("E Poe") ➞ false`
- `ValidName("E. Allan Poe") ➞ false`
- `ValidName("E. A. P.") ➞ false`
- `ValidName("Edg. A. Poe") ➞ false`
