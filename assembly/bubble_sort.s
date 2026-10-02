ARR1	DCD		10, -8, 47, 81, 4, -6, -11, 7, 30, 11
DIM		DCD		10
		
		MOV		R2, #DIM
		LDR		R2, [R2]
		MOV		R3, #ARR1
		MOV		R4, R2
		MOV		R5, R3
		
		MOV		R6, #0
		
CICLO	LDR		R7, [R3]
		LDR		R8, [R3, #4]
		CMP		R7, R8
		BLE		NEXSTEP
		
		ADD		R6, R6, #1
		STR		R8, [R3]
		STR		R7, [R3, #4]
		
NEXSTEP	ADD		R3, R3, #4
		SUB		R2, R2, #1
		CMP		R2, #1
		BGT		CICLO
		
RESET	MOV		R2, R4
		MOV		R3, R5
		CMP		R6, #0
		MOV		R6, #0
		BNE		CICLO
		
		END
