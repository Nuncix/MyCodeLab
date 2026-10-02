NUMS	DCD		9,4
RIS		FILL		4
		
		
		MOV		R5, #NUMS
		LDR		R6, [R5], #4
		LDR		R7, [R5]
		
		MOV		R3, #0
		
CICLO	CMP		R7, #0
		BEQ		FINE
		ADD		R3, R3, R6
		SUB		R7, R7, #1
		B		CICLO
		
FINE	MOV		R5, #RIS
		STR		R5, [R5]
		
		END
