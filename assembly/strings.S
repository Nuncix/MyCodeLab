TSTRING	DCB		0x41, 0x41, 0x41, 0x41, 0x42, 0x43, 0x43, 0x43, 0x43
PSTRING	DCB		0x41, 0x44, 0x43
TNUMEL	DCD		9
PNUMEL	DCD		3
RESULT	FILL		4
		
		;indirizzo	iniziale stringa t
		MOV		R0, #TSTRING
		;indirizzo	iniziale stringa p
		MOV		R1, #PSTRING
		
		MOV		R2, #TNUMEL
		LDR		R2, [R2]
		
		MOV		R3, #PNUMEL
		LDR		R3, [R3]
		
		SUB		R2, R2, R3
		;indirizzo	finale stringa t (R0 + 6)
		ADD		R4, R0, R2
		
		;indirizzo	finale stringa p (R1 + 3)
		ADD		R5, R1, R3
		
		
		STMFD	SP!, {R0, R1, R4, R5}
		BL		RICERCA
		LDR		R0, [SP], #16
		
		MOV		R1, #RESULT
		STR		R0, [R1]
		
		END
		
		;Sottoprogramma	Ricerca
		;R0		Inizio stringa T
		;R1		Inizio stringa P
		;R2		Fine    stringa T
		;R3		Fine stringa P
RICERCA	STMFD	SP!, {R0, R1, R2, R3, R4, R12, LR}
		ADD		R12, SP, #20
		LDR		R0, [R12, #8]
		LDR		R1, [R12, #12]
		LDR		R2, [R12, #16]
		LDR		R3, [R12, #20]
		
CICLO	STMFD	SP!, {R0, R1, R3}
		BL		STRCMP
		LDR		R4, [SP], #12
		CMP		R4, #0
		BGT		FINER
		ADD		R0, R0, #1
		CMP		R0, R2
		BNE		CICLO
		
		MOV		R0, #-1
		
FINER	STR		R0, [R12, #8]
		LDMFD	SP!, {R0, R1, R2, R3, R4, R12, LR}
		
		MOV		PC, LR
		
		;Sottoprogramma	string compare
STRCMP	STMFD	SP!, {R0, R1, R2, R3, R4, R5, R12}
		ADD		R12, SP, #24
		LDR		R0, [R12, #4]
		LDR		R1, [R12, #8]
		LDR		R2, [R12, #12]
		
		MOV		R5, #0
		
CICLOCMP	LDRB		R3, [R0], #1
		LDRB		R4, [R1], #1
		CMP		R3, R4
		BNE		FINECMP
		CMP		R1, R2
		BNE		CICLOCMP
		
		MOV		R5, #1
		
FINECMP	STR		R5, [R12, #4]
		LDMFD	SP!, {R0, R1, R2, R3, R4, R5, R12}
		
		MOV		PC, LR
