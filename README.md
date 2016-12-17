# Squirrel
Squirrel is an interpreted programming language with a minimal syntax inspired by Lisp.

## Table of Contents
- [Comments] (#comments)
- [Integers] (#integers)
- [Symbols] (#symbols)
- [Symbolic expressions] (#symbolic-expressions)
- [Quoted expressions] (#quoted-expressions)
- [Defining Values] (#defining-values)

## Comments
Comments are enclosed in square brackets and can span multiple lines.

```
[ this is a line comment ]

[
  and this is a
  block comment
]
```

## Integers
Integers are the only numeric type currently supported.
```
1 +2 -3
```

## Symbols
A symbol is a case-sensitive word consisting only of alphabetic characters.

```
add sub mul div
```

## Symbolic expressions
A symbolic expression (*s-expression* for short) is a sequence of expressions enclosed in parentheses where the first expression is a symbol. The symbol is treated as an operator and the remaining expressions are treated as operands.

```
(add 1 2) [ operator: add | operands: 1 2 ]
```

Nested expressions are evaluated before the whole expression.
```
(add 1 (mul 2 3)) [ operator: add | operands: 1 6 ]
```

## Quoted expressions
A quoted expression (*q-expression* for short) is a sequence of expressions enclosed in curly braces. Q-expressions evaluate to themselves, and nested expressions are not evaluated at all.

```
{add 1 2} [ -> {add 1 2} ]

{add 1 (mul 2 3}} [ -> {add 1 (mul 2 3}} ]
```

Because expressions nested inside q-expressions are not evaluated, q-expressions can be used as lists for storing data.

## Defining Values
Constant values can be defined using the builtin `def` keyword. The first argument to the `def` keyword is a list (q-expression) of symbols which are the names to define. The remaining arguments are the values to associate with each name.

```
[ defining a single value ]
(def {x} 5) [ x = 5 ]

[ defining multiple values ]
(def {y z} (mul x x) {a b c}) [ y = 25 | z = {a b c} ]
```
