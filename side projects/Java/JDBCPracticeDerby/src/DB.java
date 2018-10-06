import java.sql.Connection;
import java.sql.DriverManager;

public class DB {
    final String JDBC_DRIVE="";
    final String URL="";
    final String URESNAME ="";
    final String PASSWORD="";

    public DB() {
        Connection connection = new DriverManager.getConnection(URL, );
    }
}
