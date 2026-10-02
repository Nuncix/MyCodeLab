NUM		DCD		10
ARR		DCD		10, -4, 6, 8, 33, 14, 90, 53, -7, 32
RES		FILL		4
		
		
		MOV		R3, #NUM
		LDR		R3, [R3]
		
		MOV		R4, #ARR
		MOV		R5, #0
		
		MOV		R7, #RES
		
CICLO	LDR		R6, [R4]
		ADD		R5, R5, R6
		SUB		R3, R3, #1
		ADD		R4, R4, #4
		CMP		R3, #0
		BGT		CICLO
		
		STR		R5, [R7]
		
		END
