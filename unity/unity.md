#### Build & deploy
* Build:
    * File -> Build Settings -> WebGL -> Build
* Deploy method №1:
    * Copy files to linux server
    * Launch http server - `python -m SimpleHTTPServer 80`
* Deploy method №2:
    * Copy files to git repository
        * Delete README.md, place index.html in root
    * Configure github pages:
        * Github -> Settings -> Pages
* Other useful features:
    * File -> Build Settings -> Player Settings -> WebGL -> Resolution and Presentation
    * File -> Build Settings -> Player Settings -> WebGL -> Publishing Settings
        * May be necessary to turn off compression/turn on fallback for some primitive http servers
