SYNTAXDEF spec
FOR <http://www.emftext.org/language/spec>
START MasterSpezifikation, SubSpezifikation

OPTIONS{
 reloadGeneratorModel="true";
 generateCodeFromGeneratorModel="true"; //wichtig um Fehler im Generat zu vermeiden
 disableLaunchSupport="false";
 usePredefinedTokens="true";
 autofixSimpleLeftrecursion="true";
 //disableTokenSorting="false";
 //memoize="false";
 //resourcePluginID="net.sf.devtool.rezeptsammler.rezeptDSL.resource";
 //resourceUIPluginID="net.sf.devtool.rezeptsammler.rezeptDSL.ui";
 //basePackage="net.sf.devtool.rezeptsammler.rezeptDSL.resource";
 //srcFolder="src/main/java";
 //srcGenFolder="target/generated-sources";
 //uiSrcFolder="src/main/java";
 //uiSrcGenFolder="target/generated-sources";
}



TOKENS {
	DEFINE COMMENT $'//'(~('\n'|'\r'|'\uffff'))*$;
	//DEFINE INTEGER $('-')?('1'..'9')('0'..'9')*|'0'$;
	//DEFINE FLOAT $('-')?(('1'..'9') ('0'..'9')* | '0') '.' ('0'..'9')+ $;
	//DEFINE NUMBER $('1'..'9')+$;
}


TOKENSTYLES {
	"Masterdokument zur ", "Systemkontext", "Spezifikation des Systems " COLOR #7F0055, BOLD;
	"Liste der Abkürzungen:" COLOR #7F0055, BOLD;
	"Interner Prozess","Externer Prozess" COLOR #7F0055, BOLD;
	" * Fremdsystem" COLOR #7F0055, BOLD;
	" * System" COLOR #7F0055, BOLD;
	"Glossar" COLOR #7F0055, BOLD;
}


RULES {
	

	MasterSpezifikation ::= "Masterdokument zur "  
	model
	;
	
	SubSpezifikation ::= 
	"Spezifikationsmaster" masterSpec "."
	model
	;
		
	ModelBody ::= 
	"Spezifikation des Systems " system['"','"']  "."
	imports* 
	elements+;	
		
	MasterFile ::= specFile['"','"'] ;
	ModelImport ::= "import"  importedResource['"','"'] ".";
	
	SystemKontext ::= 
	"Systemkontext"
	"============="
	"Liste der Systeme:" 
	system schnittstellen* ;
	Hauptsystem ::= " * System" name['[',']'] "wird durch diese Spezifikation beschrieben.";
	Fremdsystem ::= " * Fremdsystem" name['[',']'] beschreibung['"','"']?;
	
	Zweck ::= 
	"Zweck des zu spezifizierenden Systems" 
	"====================================="
	"Liste der Ziele:" 
	 ziele* 
	"Abgrenzung der Ziele:"
	 nichtziele*
	 stakeholderliste ;
	
	Ziel ::= 
	"* "  
    id['[',']'] 
    kategorie['"','"']
    beschreibung['"','"'];
	
	KeinZiel ::= 
	"* "  
    id['[',']'] 
    kategorie['"','"'] 
    "Kein Ziel ist "
    beschreibung['"','"'];
	
	Stakeholderliste ::= 
	"Liste der Stakeholder:"
	stakeholder* ;
	
	Stakeholder ::= 
	"* " 
	namenskuerzel['[',']']   
	beschreibung['"','"']
	;
	
	
	Glossar ::= 
	"Glossar" 
	"======="
	"Liste der Begriffe:"
	begriffe* 	
	"Liste der Abkürzungen:"
	abkuerzungen*
	"Liste der Prozesse:"
	prozesse+
	"Liste der Prozesswörter:"
	prozesswoerter+
	"Liste der Ereignisse:"
	ereignisse*
	;
	
	BegriffsEintrag ::=
	"* " 
	begriff['[',']'] 
	definition['"','"'] synonym['"','"']* 
	;
	
	AbkuerzungsEintrag ::= 
	"* "  
	abkuerzung['[',']'] 
	definition['"','"']
	;
	
	InternerProzess ::= 
	"* " "Interner Prozess" name['[',']'] "=" beschreibung['"','"'] "Prozesswort:"  prozesswort['"','"']
	;
	ExternerProzess ::= 
	"* " "Externer Prozess" name['[',']'] "=" beschreibung['"','"'] 
	;
		
	Prozesswort ::= 
	"* " verb['[',']'] "=" beschreibung['"','"'] "Synomyme:" ("-" | synonym['"','"']+)
	;
	Ereignis ::= 
	"* " name['[',']'] "=" beschreibung['"','"']
	;
	Lastenbeschreibung ::=
	"Beschreibung der Anforderungen"
	"=============================="
	anforderungen+
	;
		
	Anforderung ::=
	"1. " id['[',']'] details "."
	;		
		
	SystemAktivitaet ::=  
	"Das System"
	rechtsverbindlichkeit['"','"'] 
	beschreibung['"','"'] 
	objekt['[',']'] 
	prozesswort['[',']']
	;
	
	EreignisAktivitaet ::=
	"Bei Ereignis"
	ausloeser['[',']'] 
	rechtsverbindlichkeit['"','"'] 
	beschreibung['"','"'] 
	objekt['[',']'] 
	prozesswort['[',']']
	;
	
	BenutzerInteraktion ::=
	subjekt['[',']']
	rechtsverbindlichkeit['"','"']
	beschreibung['"','"']
	objekt['[',']']
	prozesswort['[',']']
	;
	
	BedingteAnforderung ::=
	"Falls" vorbedingung['"','"']
	rechtsverbindlichkeit['"','"']
	beschreibung['"','"']
	objekt['[',']']
	prozesswort['[',']']
	;
	
	
}