# Why XOR Works

The XOR operator `^` has useful properties for this problem:

## Identity

\[ x \oplus 0 = x \]
(XOR-ing with 0 keeps the value unchanged).

## Self-Inverse

\[ x \oplus x = 0 \]
(XOR-ing a number with itself cancels it out).

## Commutative and Associative

The order of XOR operations doesn’t matter, i.e.,

\[ a \oplus b \oplus c = c \oplus b \oplus a \].

Using these properties:

- If you XOR all numbers in the array, pairs of identical numbers cancel out (because \[ x \oplus x = 0 \]).
- The only number that remains is the one that appears once.