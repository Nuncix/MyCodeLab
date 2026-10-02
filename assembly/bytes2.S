ARR1    DCB     0x34, 0x38
RESULT  FILL    4

        MOV     R0, #ARR1
        LDRB    R1, [R0]
        LSL     R1, R1, #4
        ADD     R0, R0, #1
        LDRB    R3, [R0]
        AND     R3, R3, #0xF
        ORR     R1, R1, R3

        MOV     R4, #RESULT
        STRB    R1, [R4]

        END