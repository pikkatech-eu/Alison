; The name of the installer - might be changed later
Name "Agadir Demo"

; The file to write
OutFile "AgadirDemo.exe"

; The default installation directory
InstallDir "$DESKTOP\Agadir"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Pages
Page Directory
Page Instfiles
;--------------------------------
; The stuff to install
Section "Files" 
  ; Set output path to the installation directory.
  ; CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r ".\Binary\Release\*.dll"
  File /r ".\Binary\Release\*.exe"
  
SectionEnd ; end the section
