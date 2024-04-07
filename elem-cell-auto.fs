: pattern ( line,pos -- pattern )
    1- dup 0 < if 
        drop 1 lshift
    else
        rshift
    then
    7 and ;

: evolve ( rule,pattern -- cell state )
    1 over lshift 
    rot and 
    swap rshift
    1 and ;
        
: generation ( line,rule -- line )
    0 -rot 
    64 0 do 
        over 63 i - pattern
        over evolve
        >r rot 1 lshift r> or -rot
    loop
    2drop ;
