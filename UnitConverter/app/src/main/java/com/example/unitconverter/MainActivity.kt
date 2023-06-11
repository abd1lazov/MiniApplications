package com.example.unitconverter

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val edit: EditText = findViewById(R.id.kilo_edit)
        val btn: Button = findViewById(R.id.btn_convert)
        val result: TextView = findViewById(R.id.result_text)

        btn.setOnClickListener(){
            val kilos: Double = edit.text.toString().toDouble()
            result.setText(""+ convertToPounds(kilos) + "\nPounds")
        }
    }
    fun convertToPounds(kilos: Double): Double{
        val pounds = kilos * 2.20462
        return pounds
    }
}