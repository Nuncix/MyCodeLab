ARR1    DCB    0x36, 0x45, 0x33, 0x32, 0x22
NUM     DCD    5

        MOV    R0, #ARR1
        MOV    R1, #0xA1
        MOV    R2, #0xF0
        AND    R1, R1, R2
        ORR
        STRB   R1, [R0, #1]


        ;LSL    R1, R1, #8


        END