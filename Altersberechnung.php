	  <?php
		$tag = $_POST['tag'];
		$mon = $_POST['mon'];
		$jahr = $_POST['jahr'];
		$Name = $_POST['Name'];
		$Stunde = $_POST['Stunde'];
		$Minute = $_POST['Minute'];
		
		$uhrzeit = date("H:i", $timestamp);
		$Stunde2 = date("H");
		$Minute2 = date("i");
		$GebZeit = ("$Stunde:$Minute");

		if (!empty($_POST['Submit']));
			{ $jetzt = mktime(0,0,0,date("m"),date("d"),date("Y"));
			  $gebur = mktime(0,0,0,$mon,$tag,$jahr);
			  
			  $AlterJahre = date("Y") - $jahr;
				if (date("m") > $mon)
					{ $AlterMonate = date("m") - $mon;
					}
				elseif (date("m") < $mon)
					{ $AlterMonate = 12 - $mon + date("m");
					}
				else
					{ $AlterMonate = 0;
					}

				if ($tag < date("d"))
					{ $AlterTage = date("d") - $tag;
					}
				elseif ($tag > date("d"))
					{ $AlterTage = 30 - $tag + date("d");
					}
				else
					{ $AlterTage = 0;
					}

				if ($AlterTage == 1)
					{ $TagTage = "Tag";
					}
				elseif ($AlterTage == 0)
					{ $TagTage = "Tage";
					}
				else
					{ $TagTage = "Tage";
					}

				if ($AlterMonate == 1)
					{ $MonatMonate = "Monat";
					}
				elseif ($AlterMonate == 0)
					{ $MonatMonate = "Monate";
					}
				else
					{ $MonatMonate = "Monate";
					}

				if ($AlterJahre == 1)
					{ $JahrJahre = "Jahr";
					}
				elseif ($AlterJahre == 0)
					{ $JahrJahre = "Jahre";
					}
				else
					{ $JahrJahre = "Jahre";
					}

			if ($Stunde2 > $Stunde)
				{ $Stundeneu = $Stunde2 - $Stunde;
				}
			elseif ($Stunde2 < $Stunde)
				{ $Stundeneu = 24 - ($Stunde - $Stunde2);
				  $AlterTage = $AlterTage - 1;
				}
			
			if ($Minute2 > $Minute)
				{ $Minuteneu = $Minute2 - $Minute;
				}
			elseif ($Minute2 < $Minute)
				{ $Minuteneu = 60 - ($Minute - $Minute2);
				}

			$ergebnis = "$Name ist $AlterJahre $JahrJahre, $AlterMonate $MonatMonate, $AlterTage $TagTage, $Stundeneu Stunden und $Minutenneu Minuten alt!";
		}
	echo $ergebnis;
?>
