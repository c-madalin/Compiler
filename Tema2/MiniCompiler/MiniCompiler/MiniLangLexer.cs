//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:/Users/cazan/Desktop/facultate folder/sem3/LFC/LFC/Tema2/MiniCompiler/MiniCompiler/MiniLang.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class MiniLangLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, IDENTIFIER=11, NUMBER=12, STRING=13, ADD=14, SUB=15, MUL=16, 
		DIV=17, MOD=18, INCREMENT=19, DECREMENT=20, ASSIGN=21, ADD_ASSIGN=22, 
		SUB_ASSIGN=23, MUL_ASSIGN=24, DIV_ASSIGN=25, MOD_ASSIGN=26, LT=27, LE=28, 
		GT=29, GE=30, EQ=31, NEQ=32, AND=33, OR=34, NOT=35, LPAREN=36, RPAREN=37, 
		LBRACE=38, RBRACE=39, COMMA=40, SEMI=41, WS=42, LINE_COMMENT=43, BLOCK_COMMENT=44;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "IDENTIFIER", "NUMBER", "STRING", "ADD", "SUB", "MUL", "DIV", 
		"MOD", "INCREMENT", "DECREMENT", "ASSIGN", "ADD_ASSIGN", "SUB_ASSIGN", 
		"MUL_ASSIGN", "DIV_ASSIGN", "MOD_ASSIGN", "LT", "LE", "GT", "GE", "EQ", 
		"NEQ", "AND", "OR", "NOT", "LPAREN", "RPAREN", "LBRACE", "RBRACE", "COMMA", 
		"SEMI", "WS", "LINE_COMMENT", "BLOCK_COMMENT"
	};


	public MiniLangLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MiniLangLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'if'", "'else'", "'while'", "'for'", "'return'", "'int'", "'float'", 
		"'double'", "'string'", "'void'", null, null, null, "'+'", "'-'", "'*'", 
		"'/'", "'%'", "'++'", "'--'", "'='", "'+='", "'-='", "'*='", "'/='", "'%='", 
		"'<'", "'<='", "'>'", "'>='", "'=='", "'!='", "'&&'", "'||'", "'!'", "'('", 
		"')'", "'{'", "'}'", "','", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "IDENTIFIER", 
		"NUMBER", "STRING", "ADD", "SUB", "MUL", "DIV", "MOD", "INCREMENT", "DECREMENT", 
		"ASSIGN", "ADD_ASSIGN", "SUB_ASSIGN", "MUL_ASSIGN", "DIV_ASSIGN", "MOD_ASSIGN", 
		"LT", "LE", "GT", "GE", "EQ", "NEQ", "AND", "OR", "NOT", "LPAREN", "RPAREN", 
		"LBRACE", "RBRACE", "COMMA", "SEMI", "WS", "LINE_COMMENT", "BLOCK_COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MiniLang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MiniLangLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,44,275,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,
		1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,6,1,6,1,
		6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,8,1,8,
		1,9,1,9,1,9,1,9,1,9,1,10,1,10,5,10,146,8,10,10,10,12,10,149,9,10,1,11,
		4,11,152,8,11,11,11,12,11,153,1,11,1,11,4,11,158,8,11,11,11,12,11,159,
		3,11,162,8,11,1,12,1,12,1,12,1,12,5,12,168,8,12,10,12,12,12,171,9,12,1,
		12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,1,18,1,18,1,
		18,1,19,1,19,1,19,1,20,1,20,1,21,1,21,1,21,1,22,1,22,1,22,1,23,1,23,1,
		23,1,24,1,24,1,24,1,25,1,25,1,25,1,26,1,26,1,27,1,27,1,27,1,28,1,28,1,
		29,1,29,1,29,1,30,1,30,1,30,1,31,1,31,1,31,1,32,1,32,1,32,1,33,1,33,1,
		33,1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,39,1,39,1,40,1,
		40,1,41,4,41,245,8,41,11,41,12,41,246,1,41,1,41,1,42,1,42,1,42,1,42,5,
		42,255,8,42,10,42,12,42,258,9,42,1,42,1,42,1,43,1,43,1,43,1,43,5,43,266,
		8,43,10,43,12,43,269,9,43,1,43,1,43,1,43,1,43,1,43,1,267,0,44,1,1,3,2,
		5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,
		16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,
		28,57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,
		40,81,41,83,42,85,43,87,44,1,0,6,3,0,65,90,95,95,97,122,4,0,48,57,65,90,
		95,95,97,122,1,0,48,57,2,0,34,34,92,92,3,0,9,10,13,13,32,32,2,0,10,10,
		13,13,283,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,
		0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,
		1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,
		0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,
		1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,
		0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,
		1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,
		0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,
		1,0,0,0,1,89,1,0,0,0,3,92,1,0,0,0,5,97,1,0,0,0,7,103,1,0,0,0,9,107,1,0,
		0,0,11,114,1,0,0,0,13,118,1,0,0,0,15,124,1,0,0,0,17,131,1,0,0,0,19,138,
		1,0,0,0,21,143,1,0,0,0,23,151,1,0,0,0,25,163,1,0,0,0,27,174,1,0,0,0,29,
		176,1,0,0,0,31,178,1,0,0,0,33,180,1,0,0,0,35,182,1,0,0,0,37,184,1,0,0,
		0,39,187,1,0,0,0,41,190,1,0,0,0,43,192,1,0,0,0,45,195,1,0,0,0,47,198,1,
		0,0,0,49,201,1,0,0,0,51,204,1,0,0,0,53,207,1,0,0,0,55,209,1,0,0,0,57,212,
		1,0,0,0,59,214,1,0,0,0,61,217,1,0,0,0,63,220,1,0,0,0,65,223,1,0,0,0,67,
		226,1,0,0,0,69,229,1,0,0,0,71,231,1,0,0,0,73,233,1,0,0,0,75,235,1,0,0,
		0,77,237,1,0,0,0,79,239,1,0,0,0,81,241,1,0,0,0,83,244,1,0,0,0,85,250,1,
		0,0,0,87,261,1,0,0,0,89,90,5,105,0,0,90,91,5,102,0,0,91,2,1,0,0,0,92,93,
		5,101,0,0,93,94,5,108,0,0,94,95,5,115,0,0,95,96,5,101,0,0,96,4,1,0,0,0,
		97,98,5,119,0,0,98,99,5,104,0,0,99,100,5,105,0,0,100,101,5,108,0,0,101,
		102,5,101,0,0,102,6,1,0,0,0,103,104,5,102,0,0,104,105,5,111,0,0,105,106,
		5,114,0,0,106,8,1,0,0,0,107,108,5,114,0,0,108,109,5,101,0,0,109,110,5,
		116,0,0,110,111,5,117,0,0,111,112,5,114,0,0,112,113,5,110,0,0,113,10,1,
		0,0,0,114,115,5,105,0,0,115,116,5,110,0,0,116,117,5,116,0,0,117,12,1,0,
		0,0,118,119,5,102,0,0,119,120,5,108,0,0,120,121,5,111,0,0,121,122,5,97,
		0,0,122,123,5,116,0,0,123,14,1,0,0,0,124,125,5,100,0,0,125,126,5,111,0,
		0,126,127,5,117,0,0,127,128,5,98,0,0,128,129,5,108,0,0,129,130,5,101,0,
		0,130,16,1,0,0,0,131,132,5,115,0,0,132,133,5,116,0,0,133,134,5,114,0,0,
		134,135,5,105,0,0,135,136,5,110,0,0,136,137,5,103,0,0,137,18,1,0,0,0,138,
		139,5,118,0,0,139,140,5,111,0,0,140,141,5,105,0,0,141,142,5,100,0,0,142,
		20,1,0,0,0,143,147,7,0,0,0,144,146,7,1,0,0,145,144,1,0,0,0,146,149,1,0,
		0,0,147,145,1,0,0,0,147,148,1,0,0,0,148,22,1,0,0,0,149,147,1,0,0,0,150,
		152,7,2,0,0,151,150,1,0,0,0,152,153,1,0,0,0,153,151,1,0,0,0,153,154,1,
		0,0,0,154,161,1,0,0,0,155,157,5,46,0,0,156,158,7,2,0,0,157,156,1,0,0,0,
		158,159,1,0,0,0,159,157,1,0,0,0,159,160,1,0,0,0,160,162,1,0,0,0,161,155,
		1,0,0,0,161,162,1,0,0,0,162,24,1,0,0,0,163,169,5,34,0,0,164,168,8,3,0,
		0,165,166,5,92,0,0,166,168,9,0,0,0,167,164,1,0,0,0,167,165,1,0,0,0,168,
		171,1,0,0,0,169,167,1,0,0,0,169,170,1,0,0,0,170,172,1,0,0,0,171,169,1,
		0,0,0,172,173,5,34,0,0,173,26,1,0,0,0,174,175,5,43,0,0,175,28,1,0,0,0,
		176,177,5,45,0,0,177,30,1,0,0,0,178,179,5,42,0,0,179,32,1,0,0,0,180,181,
		5,47,0,0,181,34,1,0,0,0,182,183,5,37,0,0,183,36,1,0,0,0,184,185,5,43,0,
		0,185,186,5,43,0,0,186,38,1,0,0,0,187,188,5,45,0,0,188,189,5,45,0,0,189,
		40,1,0,0,0,190,191,5,61,0,0,191,42,1,0,0,0,192,193,5,43,0,0,193,194,5,
		61,0,0,194,44,1,0,0,0,195,196,5,45,0,0,196,197,5,61,0,0,197,46,1,0,0,0,
		198,199,5,42,0,0,199,200,5,61,0,0,200,48,1,0,0,0,201,202,5,47,0,0,202,
		203,5,61,0,0,203,50,1,0,0,0,204,205,5,37,0,0,205,206,5,61,0,0,206,52,1,
		0,0,0,207,208,5,60,0,0,208,54,1,0,0,0,209,210,5,60,0,0,210,211,5,61,0,
		0,211,56,1,0,0,0,212,213,5,62,0,0,213,58,1,0,0,0,214,215,5,62,0,0,215,
		216,5,61,0,0,216,60,1,0,0,0,217,218,5,61,0,0,218,219,5,61,0,0,219,62,1,
		0,0,0,220,221,5,33,0,0,221,222,5,61,0,0,222,64,1,0,0,0,223,224,5,38,0,
		0,224,225,5,38,0,0,225,66,1,0,0,0,226,227,5,124,0,0,227,228,5,124,0,0,
		228,68,1,0,0,0,229,230,5,33,0,0,230,70,1,0,0,0,231,232,5,40,0,0,232,72,
		1,0,0,0,233,234,5,41,0,0,234,74,1,0,0,0,235,236,5,123,0,0,236,76,1,0,0,
		0,237,238,5,125,0,0,238,78,1,0,0,0,239,240,5,44,0,0,240,80,1,0,0,0,241,
		242,5,59,0,0,242,82,1,0,0,0,243,245,7,4,0,0,244,243,1,0,0,0,245,246,1,
		0,0,0,246,244,1,0,0,0,246,247,1,0,0,0,247,248,1,0,0,0,248,249,6,41,0,0,
		249,84,1,0,0,0,250,251,5,47,0,0,251,252,5,47,0,0,252,256,1,0,0,0,253,255,
		8,5,0,0,254,253,1,0,0,0,255,258,1,0,0,0,256,254,1,0,0,0,256,257,1,0,0,
		0,257,259,1,0,0,0,258,256,1,0,0,0,259,260,6,42,0,0,260,86,1,0,0,0,261,
		262,5,47,0,0,262,263,5,42,0,0,263,267,1,0,0,0,264,266,9,0,0,0,265,264,
		1,0,0,0,266,269,1,0,0,0,267,268,1,0,0,0,267,265,1,0,0,0,268,270,1,0,0,
		0,269,267,1,0,0,0,270,271,5,42,0,0,271,272,5,47,0,0,272,273,1,0,0,0,273,
		274,6,43,0,0,274,88,1,0,0,0,10,0,147,153,159,161,167,169,246,256,267,1,
		6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
