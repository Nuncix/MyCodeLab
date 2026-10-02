ARR1		DCD		3, 0, 5, 1, 4, 91
ARR2		DCD		1, 3, 0, 24, 51, 7
NUMEL	        DCD		6
RISULT	        FILL		4
		
		MOV		R0,#ARR1
		MOV		R1,#ARR2
		
		MOV		R2,#NUMEL
		LDR		R2, [R2]
		
		STMFD	        SP!, {R0, R1, R2}
		BL		PRODS
		LDR		R0, [SP], #12
		
		MOV		R1,#RISULT
		STR		R0, [R1]
		
		END
		
;Prodotto scalare
PRODS	        STMFD	        SP!, {R0,R1,R2,R3,R4,R5,R12, LR}
		ADD		R12, SP, #24
		LDR		R0, [R12, #8]
		LDR		R1, [R12, #12]
		LDR		R2, [R12, #16]
		
		MOV		R3, #0
		
CICLOPS	        CMP		R2, #0
		BEQ		FINEPS
		LDR		R4, [R0, #4]
		LDR		R5, [R1, #4]
		STMFD	        SP!, {R4,R5}
		BL		MULT
		LDR		R4, [SP], #8
		ADD		R3, R3, R4
		SUB		R2, R2, #1
		B		CICLOPS
		
FINEPS	        STR		R3, [R12, #8]
		LDMFD	        SP!, {R0, R1, R2, R3, R4, R5, R12, LR}
		MOV		PC, LR
		
;Moltiplicazione
MULT		STMFD	        SP!, {R0, R1, R2, R12}
		ADD		R12, SP, #12
		LDR		R0, [R12,#4]
		LDR		R1, [R12,#4]
		
		MOV		R2, #0
		
CICLOM	        CMP		R1, #0
		BEQ		FINEM
		ADD		R2, R2, R0
		SUB		R1, R1, #1
		B		CICLOM
		
FINEM	        STR		R2, [R12,#4]
		LDMFD	        SP!, {R0, R1, R2, R12}
		MOV		PC, LR
