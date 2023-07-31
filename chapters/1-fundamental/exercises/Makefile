DLLS = $(addprefix -reference:,$(filter %.dll,$^))
CODE = $(filter %.cs,$^)
MKEXE = mcs -target:exe -out:$@ $(DLLS) $(CODE)
MKLIB = mcs -target:library -out:$@ $(DLLS) $(CODE)
DIR = ../../../matlib


all : gauss.svg poisson.svg binomial.svg Out.function1.txt Out.poisson.txt Out.binomial.txt

main.exe : main.cs matrix.dll ; 
	$(MKEXE)


Out.function1.txt : main.exe
	mono $< > $@ -gauss


Out.poisson.txt : main.exe
	mono $< > $@ -poisson

Out.binomial.txt : main.exe
	mono $< > $@ -binomial

matrix.dll : $(DIR)/pdf/pdf.cs $(DIR)/matrix/matrix.cs $(DIR)/matrix/vector.cs $(DIR)/matrix/QRGS.cs ; 
	$(MKLIB)




gauss.svg : gauss.gpi Out.function1.txt
	gnuplot $<


poisson.svg : poisson.gpi Out.poisson.txt
	gnuplot $<


binomial.svg : binomial.gpi Out.binomial.txt
	gnuplot $<


i.PHONY: clean
clean:
	-$(RM) out* *.txt *.exe *.dll *.data *.svg
