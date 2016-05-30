package com.meta.qrreaderapp;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import android.app.AlertDialog;
import android.widget.EditText;
import android.content.DialogInterface;
import android.text.InputType;

import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

public class MainActivity extends AppCompatActivity implements OnClickListener{

    private Button scanBtn;
    private TextView tvResponse, tvScanStatus;

    private String deviceId = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        scanBtn = (Button)findViewById(R.id.bt_scan);
        tvResponse = (TextView)findViewById(R.id.tv_response);
        tvScanStatus = (TextView)findViewById(R.id.tv_scanStatus);

        scanBtn.setOnClickListener(this);

        inputDeviceId();
    }

    public void inputDeviceId(){
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Enter device Id:");

        final EditText input = new EditText(this);
        input.setInputType(InputType.TYPE_CLASS_TEXT);
        builder.setView(input);

        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                deviceId = input.getText().toString();
            }
        });
        builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        builder.show();
    }

    @Override
    public void onClick(View v) {
        tvScanStatus.setText("scanning...");
        tvResponse.setText("");

        //start the scan intent
        if(v.getId()==R.id.bt_scan){
            IntentIntegrator scanIntegrator = new IntentIntegrator(this);
            scanIntegrator.initiateScan(IntentIntegrator.QR_CODE_TYPES);
        }
    }

    @Override
    public void onActivityResult(int requestCode, int resultCode, Intent intent) {
        //retrieve scan result
        IntentResult scanningResult = IntentIntegrator.parseActivityResult(requestCode, resultCode, intent);

        if (scanningResult != null) {
            String scanContent = scanningResult.getContents();
            tvScanStatus.setText("Scan successful.");
            tvResponse.setText("connecting with DB...");

            new DBConnectActivity(this, tvResponse).execute(deviceId, scanContent);
        }else{
            tvScanStatus.setText("Scan failed.");
            Toast toast = Toast.makeText(getApplicationContext(),
                    "No scan data received!", Toast.LENGTH_SHORT);
            toast.show();
        }
    }
}
