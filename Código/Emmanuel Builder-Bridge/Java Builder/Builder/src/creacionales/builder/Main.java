package creacionales.builder;

public class Main {
	 public static void main (String[] args){
	        AutoDirector director = new AutoDirector();
	        director.setAutoBuilder(new FordBuilder());
	        director.contructAuto();
	        Auto auto = director.getAuto();
	        
	        System.out.println(auto.getMarca());
	        System.out.println(auto.getModelo());
	    }

}
