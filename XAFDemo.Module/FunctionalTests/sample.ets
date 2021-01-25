;#DropDB XAFDemoEasyTest

#Application XAFDemoWin
#Application XAFDemoWeb
#IfDef XAFDemoWin

*Action About...
 
*Action OK

#EndIf

#IfDef XAFDemoWeb
!Action Navigation(My Details)
#EndIf
