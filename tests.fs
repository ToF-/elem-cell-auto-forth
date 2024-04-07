require ffl/tst.fs
require elem-cell-auto.fs

: binary 2 base ! ;
: 0b binary ;
: dec decimal ;

\  63            49                                               0
\  v             v                                                v
0b 1000100000010010001101000101011001111000100110101100110111101111 constant sample

dec sample 0 pattern 0b 110 ?s
dec sample 1 pattern 0b 111 ?s
dec sample 2 pattern 0b 111 ?s 
dec sample 3 pattern 0b 011 ?s
dec sample 4 pattern 0b 101 ?s
dec sample 5 pattern 0b 110 ?s
dec sample 49 pattern 0b 010 ?s
dec sample 61 pattern 0b 000 ?s
dec sample 62 pattern 0b 100 ?s
dec sample 63 pattern 0b 010 ?s

0b 10110100 constant rule
dec

rule 0 evolve 0 ?s
rule 1 evolve 0 ?s
rule 2 evolve 1 ?s
rule 3 evolve 0 ?s
rule 4 evolve 1 ?s
rule 5 evolve 1 ?s
rule 6 evolve 0 ?s
rule 7 evolve 1 ?s

0b 1000100000010010001101000101011001111000100110101100110111110110 constant result

sample rule generation
result ?u
bye
