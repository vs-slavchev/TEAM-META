package com.meta.qrreaderapp;

import android.content.Context;
import android.os.AsyncTask;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.URL;
import java.net.URLConnection;
import java.net.URLEncoder;

public class DBConnectActivity extends AsyncTask<String,Void,String> {

    private Context context;
    private TextView response;


    public DBConnectActivity(Context context, TextView response) {
        this.context = context;
        this.response = response;
    }

    @Override
    protected String doInBackground(String... params) {
        String phone_id = params[0];
        String qr_value = params[1];

        String link = "http://athena.fhict.nl/users/i345959/php/android_db_connector.php";
        try {
            String data = URLEncoder.encode("phone_id", "UTF-8") + "=" + URLEncoder.encode(phone_id, "UTF-8")
                    + "&" + URLEncoder.encode("qr_value", "UTF-8") + "=" + URLEncoder.encode(qr_value, "UTF-8");

            URL url = new URL(link);
            URLConnection conn = url.openConnection();

            conn.setDoOutput(true);
            OutputStreamWriter wr = new OutputStreamWriter(conn.getOutputStream());

            wr.write(data);
            wr.flush();

            BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));

            StringBuilder sb = new StringBuilder();
            String line = null;

            // Read Server Response
            while((line = reader.readLine()) != null)
            {
                sb.append(line);
                break;
            }
            // the returned string is the number of affected rows
            return sb.toString().equals("1") ? "Connection successful." : "Previous QR code is not yet serviced.";

        } catch(Exception e){
            return new String("Exception: " + e.getMessage());
        }
    }

    @Override
    protected void onPostExecute(String result){
        this.response.setText(result);
    }
}
