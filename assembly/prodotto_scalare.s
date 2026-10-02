ARR1		DCD		44, 5, 11, 4
ARR2		DCD		2, 1, 99, 4, 5
DIM			DCD		5
RIS			FILL	4
		
			MOV		R2, #ARR1
			MOV		R3, #ARR2
		
			MOV		R4, #DIM
			LDR		R4, [R4]
		
			MOV		R5, #0
		
CICLO		LDR		R6, [R2], #4
			LDR		R7, [R3], #4
			MOV		R8, #0
		
CMULT		CMP		R7, #0
			BEQ		NEXTSTEP
			ADD		R8, R8, R6
			SUB		R7, R7, #1
			B		CMULT
		
NEXTSTEP	ADD		R5, R5, R8
			SUB		R4, R4, #1
			CMP		R4, #0
			BGT		CICLO
		
			MOV		R2, #RIS
			STR		R5, [R2]
		
		END
