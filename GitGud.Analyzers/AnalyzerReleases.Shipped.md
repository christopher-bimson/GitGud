## Release 1.0

### New Rules

Rule ID | Category | Severity | Notes                                                                                 
--------|----------|----------|--------------------------------------------------------------------------------------
GUD001  | Usage    | Warning  | Don't use the `null` keyword.                                                        
GUD002  | Usage    | Warning  | Don't use nullable types.                                                            
GUD003  | Usage    | Warning  | Use `DateTime.UtcNow` instead of `DateTime.Now`.                                     
GUD004  | Usage    | Warning  | Don't use `DateTime.UtcNow`. Use an injectable abstraction to better support testing. 