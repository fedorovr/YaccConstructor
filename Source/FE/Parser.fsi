// Signature file for parser generated by fsyacc
#light "off"
module Yard.Core.GrammarParser
open Yard.Core
type token = 
  | PATTERN of (IL.Source.t)
  | PARAM of (IL.Source.t)
  | PREDICATE of (IL.Source.t)
  | ACTION of (IL.Source.t)
  | STRING of (IL.Source.t)
  | LIDENT of (IL.Source.t)
  | UIDENT of (IL.Source.t)
  | COMMUT
  | DLESS
  | DGREAT
  | RPAREN
  | LPAREN
  | QUESTION
  | PLUS
  | STAR
  | BAR
  | EQUAL
  | SEMICOLON
  | COLON
  | EOF
type tokenId = 
    | TOKEN_PATTERN
    | TOKEN_PARAM
    | TOKEN_PREDICATE
    | TOKEN_ACTION
    | TOKEN_STRING
    | TOKEN_LIDENT
    | TOKEN_UIDENT
    | TOKEN_COMMUT
    | TOKEN_DLESS
    | TOKEN_DGREAT
    | TOKEN_RPAREN
    | TOKEN_LPAREN
    | TOKEN_QUESTION
    | TOKEN_PLUS
    | TOKEN_STAR
    | TOKEN_BAR
    | TOKEN_EQUAL
    | TOKEN_SEMICOLON
    | TOKEN_COLON
    | TOKEN_EOF
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startfile
    | NONTERM_file
    | NONTERM_action_opt
    | NONTERM_rule_nlist
    | NONTERM_rule
    | NONTERM_plus_opt
    | NONTERM_formal_meta_param_opt
    | NONTERM_formal_meta_list
    | NONTERM_param_opt
    | NONTERM_alts
    | NONTERM_bar_seq_nlist
    | NONTERM_seq
    | NONTERM_seq_elem_list
    | NONTERM_seq_elem
    | NONTERM_predicate_opt
    | NONTERM_bound
    | NONTERM_patt
    | NONTERM_prim
    | NONTERM_meta_param
    | NONTERM_meta_params
    | NONTERM_meta_param_opt
    | NONTERM_call
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val file : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ((IL.Source.t, IL.Source.t)IL.Definition.t) 
