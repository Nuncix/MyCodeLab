ARR1	DCD		6, -55, 3, 67, 1
NUM		DCD		5
RIS		FILL	4
		
		MOV		R7, #ARR1
		MOV		R8, #NUM
		LDR		R8, [R8]
		
		STMFD	SP!, {R7, R8}
		BL		SOMMA
		LDR		R5, [SP]
		ADD		SP, SP, #8
		
		MOV		R6, #RIS
		STR		R5, [R6]
		
		END
		
SOMMA	STMFD	SP!, {R0, R1, R2, R3}
		LDR		R0, [SP, #16]
		LDR		R1, [SP, #20]
		
		MOV		R2, #0
		
CICLOS	LDR		R3, [R0]
		ADD		R2, R2, R3
		SUB		R1, R1, #1
		ADD		R0, R0, #4
		CMP		R1, #0
		BGT		CICLOS
		
		STR		R2, [SP, #16]
		LDMFD	SP!, {R0, R1, R2, R3}
		
		MOV		PC, LR
		
		END
