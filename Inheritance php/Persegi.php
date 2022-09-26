<?php
        class BangunDatar{
            public $Persegi;
            function persegi($per){
                $this->Persegi= $per;
            }
        }
        class Persegi extends BangunDatar{
            function getInfoPersegi(){
                $this->getInfoPersegi();
            }
        }
        class Luas extends BangunDatar{
            function getInfoPersegi(){
                return $this->getInfoPersegi * $this->getInfoPersegi;
            } 
        }
        class Keliling extends BangunDatar{
            function getInfoPersegi(){
                return $this->getInfoPersegi * 4;
            }
        }
        ?>