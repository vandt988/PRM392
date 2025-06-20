package com.example.fap;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.application_student);

        List<Test_ApplicationObject> list = new ArrayList<>();
        list.add(new Test_ApplicationObject("Approved",
                "Đơn 1", "12/05/2025",
                "Đơn của em đã được xử lý Đơn của em đã được xử lý Đơn của em đã được xử lý Đơn của em đã được xử lý Đơn của em đã được xử lý",
                "Đơn xin nghỉ học"));
        list.add(new Test_ApplicationObject("Approved",
                "Đơn 2", "12/03/2025",
                "Đơn đã được chuyển sang phòng tuyển sinh",
                "Đơn xin đi học muộn"));
        list.add(new Test_ApplicationObject("Approved",
                "Đơn 3", "19/05/2025",
                "Không có bài thi", "Đơn xin phúc khảo"));
        list.add(new Test_ApplicationObject("Approved",
                "Đơn 4", "19/05/2024",
                "ABCXYZ", "Đơn xin phúc khảo Đơn xin phúc khảo Đơn xin phúc khảo Đơn xin phúc khảo Đơn xin đi học muộn Đơn xin phúc khảo Đơn xin đi học muộn Đơn xin phúc khảo Đơn xin đi học muộn Đơn xin phúc khảo Đơn xin đi học muộn"));

        Test_ApplicationAdapter adapter = new Test_ApplicationAdapter(list);
        RecyclerView rec = findViewById(R.id.rec_chapter);
        rec.setLayoutManager(new LinearLayoutManager(this));
        rec.setAdapter(adapter);
    }
}