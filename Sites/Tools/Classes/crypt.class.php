<?php

    class Crypt
    {
        public static $enum = array();

        public function __construct()
        {
            #Crypt::$enum = array("A" => "A", "a" => "a");

        }

        function Binario_($letra){          
            return $this -> R_Code("Bi", $letra);
        }

        function Tecla_($letra){
            Crypt::$enum = array(
                "A" => "65","B" => "66","C" => "67", "D" => "68", "E" => "69", "F" => "70",
                "G" => "71", "H" => "72", "I" => "73", "J" => "74", "K" => "75", "L" => "76",
                "M" => "77", "N" => "78", "O" => "79", "P" => "80", "Q" => "81", "R" => "82",
                "S" => "83", "T" => "84", "U" => "85", "V" => "86", "W" => "87", "X" => "88", "Y" => "89", "Z" => "90",
                "1" => "49", "2" => "50", "3" => "51", "4" => "52", "5" => "53", "6" => "54",
                "7" => "55", "8" => "56", "9" => "57", "0" => "48"
            );
            return $this -> R_Code("Te", $letra);
        }

        function Morse_($letra){
            Crypt::$enum = array(
                "A" => ".-","B" => "-...","C" => "-.-.", "D" => "-..", "E" => ".", "F" => "..-.",
                "G" => "--.", "H" => "....", "I" => "..", "J" => ".---", "K" => "-.-", "L" => ".-..",
                "M" => "--", "N" => "-.", "O" => "---", "P" => ".--.", "Q" => "--.-", "R" => ".-.",
                "..." => "83", "T" => "-", "U" => "..-", "V" => "...-", "W" => ".--", "X" => "-..-", "Y" => "-.---", "Z" => "-.."
                ,"Ñ" => "--.--","1" => ".----","2" => "..---","3" => "...--","4" => "....-","5" => ".....",
                "6" => "-....","7" => "--...","8" => "---..","9" => "----.","0" => "-----","." => ".-.-.-",
                "," => "--..--",":" => "---...","-" => "-....-","(" => "-.--.-",")" => "-.--.-","=" => "-...-",
                ";" => "-.-.-.","..--..","_" => "--...","/" => "-..-."
            );
            return $this -> R_Code("Mo", $letra);
        }

        function Alfa_Num($letra){ 
            Crypt::$enum = array(
                    "A" => "126","B" => "225","C" => "324", "D" => "423", "E" => "522", "F" => "621",
                    "G" => "720", "H" => "819", "I" => "918", "J" => "1017", "K" => "1116", "L" => "1215",
                    "M" => "1314", "N" => "1413", "O" => "1512", "P" => "1611", "Q" => "1710", "R" => "189",
                    "S" => "198", "T" => "207", "U" => "216", "V" => "225", "W" => "234", "X" => "243", "Y" => "252", "Z" => "261"
                );
            return $this -> R_Code("Al", $letra);
        }

        function Alfa_rNum($letra){
            Crypt::$enum = array(
                "A" => "16216","B" => "25225","C" => "34234", "D" => "43243", "E" => "52252", "F" => "61261",
                "G" => "70270", "H" => "89189", "I" => "98198", "J" => "171017", "K" => "161116", "L" => "151215",
                "M" => "141314", "N" => "131413", "O" => "121512", "P" => "111611", "Q" => "101710", "R" => "19819",
                "S" => "18918", "T" => "27027", "U" => "26126", "V" => "25225", "W" => "24324", "X" => "23423", "Y" => "22522", "Z" => "21621"
            );
            return $this -> R_Code("Ar", $letra);
        }

        function Tecla_r($letra){
            Crypt::$enum = array(
                "A" => "56","B" => "99","C" => "76", "D" => "86", "E" => "96", "F" => "07",
                "G" => "17", "H" => "27", "I" => "37", "J" => "47", "K" => "57", "L" => "67",
                "M" => "77", "N" => "87", "O" => "97", "P" => "08", "Q" => "18", "R" => "28",
                "S" => "38", "T" => "48", "U" => "58", "V" => "68", "W" => "78", "X" => "88", "Y" => "98", "Z" => "09",
                "1" => "94", "2" => "05", "3" => "15", "4" => "25", "5" => "35", "6" => "45",
                "7" => "55", "8" => "65", "9" => "75", "0" => "84"
            );
            return $this -> R_Code("Tr", $letra);
        }

        function Tecla_m($letra){
            Crypt::$enum = array(
                "A" => "6905","B" => "6896","C" => "6887", "D" => "6878", "E" => "6869", "F" => "7850",
                "G" => "7841", "H" => "7832", "I" => "7823", "J" => "7814", "K" => "7805", "L" => "7796",
                "M" => "7787", "N" => "7768", "O" => "7759", "P" => "8740", "Q" => "8731", "R" => "8722",
                "S" => "8713", "T" => "8704", "U" => "8695", "V" => "8686", "W" => "8677", "X" => "8668", "Y" => "8659", "Z" => "9640",
                "1" => "4569", "2" => "5550", "3" => "5541", "4" => "5532", "5" => "5523", "6" => "5514",
                "7" => "5505", "8" => "5496", "9" => "5487", "0" => "4578"
            );
            return $this -> R_Code("tm", $letra);
        }


        private function R_Code($tipo,$letra)
        {
            $code = "";

            switch($tipo)
            {
                case "Bi":
                    $code = decbin(ord($letra));
                    break;
                case "Te":
                case "Al":
                case "Ar":
                case "Tr":
                case "Mo":
                case "Tm":
                    @$code = Crypt::$enum[$letra];
                        break;
            }

            return $code;
        }

         function decode_($seq)
        {
            $this -> Binario_("");
            $result = array_search($seq,Crypt::$enum);
            tese:
            if($result == ""){
                $this -> Morse_("");
                $result = array_search($seq,Crypt::$enum); 
                if($result == ""){$result = 1;}
            }else if($result == 1){
                $this -> Tecla_("");
                $result = array_search($seq,Crypt::$enum);
                if($result == ""){$result = 2;}
            }else if($result == 2){             
                $this -> Tecla_r("");
                $result = array_search($seq,Crypt::$enum); 
                if($result == ""){$result = 3;}
            }
            else if($result== 3){
                $this -> Tecla_m("");
                $result = array_search($seq,Crypt::$enum);
                if($result == ""){$result = 4;} 
            }
            else if($result == 4){
                $this -> Alfa_Num("");
                $result = array_search($seq,Crypt::$enum);
                if($result == ""){$result = 5;}
            }else if($result == 5){
                $this -> Alfa_rNum("");
                $result = array_search($seq,Crypt::$enum); 
                if($result == ""){$result = 6;}
            }else if($result == 6){
                $result =  "unknown";
            }
            if($result == 1 ||$result == 2 ||$result == 3 ||$result == 4 ||$result == 5 ||$result == 6)
            {
                goto tese;
            }
            return $result;
        }
    }


?>