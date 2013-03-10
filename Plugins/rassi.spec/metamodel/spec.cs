SYNTAXDEF spec
FOR <http://www.emftext.org/language/spec>
START MasterSpezifikation, SubSpezifikation

OPTIONS{
 reloadGeneratorModel="true";
 generateCodeFromGeneratorModel="true"; //wichtig um Fehler im Generat zu vermeiden
 disableLaunchSupport="false";
 usePredefinedTokens="true";
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
	DEFINE FLOAT $('-')?(('1'..'9') ('0'..'9')* | '0') '.' ('0'..'9')+ $;
}


TOKENSTYLES {
	"Masterdokument zur ", "Systemkontext", "Spezifikation des Systems " COLOR #7F0055, BOLD;
	"Prozess" COLOR #7F0055, BOLD;
	"Ereignis" COLOR #7F0055, BOLD;
	"Prozesswort" COLOR #7F0055, BOLD;
	"Anforderung" COLOR #7F0055, BOLD;
	"Abk" COLOR #7F0055, BOLD;
	"Begriff" COLOR #7F0055, BOLD;
	" * Fremdsystem" COLOR #7F0055, BOLD;
	" * System" COLOR #7F0055, BOLD;
	"Glossar" COLOR #7F0055, BOLD;
	"test2" COLOR #7F0055, BOLD;
	"test3" COLOR #7F0055, BOLD;
	"test4" COLOR #7F0055, BOLD;
	"test5" COLOR #7F0055, BOLD;
	"test6" COLOR #7F0055, BOLD;
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
	 stakeholderliste ;
	
	Ziel ::= 
	" * "  
    id['[',']'] 
    kategorie['"','"']
    beschreibung['"','"'];
	
	Stakeholderliste ::= 
	"Liste der Stakeholder:"
	stakeholder* ;
	
	Stakeholder ::= 
	" * " 
	namenskuerzel['[',']']   
	beschreibung['"','"'];
	
	
	Glossar ::= 
	"Glossar" 
	"======="
	( "test1" ":" test1  "test2" ":" test2  "test3" ":" test3 "test4" ":" test4  "test5" ":" test5  "test6" ":" test6 )?;
	Begriff ::= "Begriff" "{" "}";
	Abk ::= "Abk" "{" "}";
	
	Prozess ::= "Prozess" "{" "}";
	Ereignis ::= "Ereignis" "{" "}";
	Prozesswort ::= "Prozesswort" "{" "}";
	Anforderung ::= "Anforderung" "{" "}";
	
	
	
	
	
	
}