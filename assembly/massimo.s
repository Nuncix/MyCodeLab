ARR1        DCD		1, 44, -12, 5
NUMEL	    DCD		4
RESULT	    FILL		8
    
		    MOV		R0, #ARR1
		    MOV		R1, #NUMEL
		    LDR		R1, [R1]
    
		    STMFD	SP!, {R0, R1}
		    BL		CALCMAX
		    LDMFD	SP!, {R0, R1}
		    MOV		R0, #RESULT
		    STR		R2, [R0]
		    STR		R3, [R0, #4]
    
		    END
    
		    ;R0		= Puntatore array, R1 = Dimensione array
		    ;R2		= Massimo parziale, R3 = elemento attuale
		    ;R4		= Indirizzo del massimo
CALCMAX	    STMFD	SP!, {R0, R1, R2, R3, R12}
		    ADD		R12, SP, #20
		    LDR		R0, [R12, #4]
		    LDR		R1, [R12, #8]
    
		    LDR		R2, [R0]
		    MOV		R4, R0
    
CICLOMAX    CMP		R1, #0
		    BEQ		NEXSTEP
		    LDR		R3, [R0]
		    CMP		R3, R2
		    BLE		FINEC
		    MOV		R2, R3
		    MOV		R4, R0
    
FINEC	    SUB		R1, R1, #1
		    ADD		R0, R0, #4
		    B		CICLOMAX
    
NEXSTEP	    STR		R2, [R12, #4]
		    STR		R4, [R12, #8]
    
		    LDMFD	SP!, {R0, R1, R2, R3, R12}
		    MOV		PC, LR
