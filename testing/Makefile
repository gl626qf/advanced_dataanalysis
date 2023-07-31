DLLS = $(addprefix -reference:,$(filter %.dll,$^))
CODE = $(filter %.cs,$^)
MKEXE = mcs -target:exe -out:$@ $(DLLS) $(CODE)
MKLIB = mcs -target:library -out:$@ $(DLLS) $(CODE)
DIR = ../../../matlib


all : Out.txt

main.exe : main.cs  ; 
	$(MKEXE)


Out.txt : main.exe
	mono $< > $@ 



# matrix.dll : $(DIR)/pdf/pdf.cs $(DIR)/matrix/matrix.cs $(DIR)/matrix/vector.cs $(DIR)/matrix/QRGS.cs ; 
# 	$(MKLIB)





i.PHONY: clean
clean:
	-$(RM) out* *.txt *.exe *.dll *.data *.svg
