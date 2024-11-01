using Sandbox;


string[] namesInFindingNemoMovie = new[] {"Marlin", "Nemo", "Dory", "Gill", "Bloat", "Peach", "Gurgle", "Bubbles", "Deb", "Jacques", "Nigel", "Bruce", "Anchor", "Chum", "Crush", "Squirt"};


string[] nemo100 = Enumerable.Repeat("nemo", 1000).ToArray();

BigO o = new BigO();

o.FindNemo(nemo100);