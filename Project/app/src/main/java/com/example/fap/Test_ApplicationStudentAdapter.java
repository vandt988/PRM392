package com.example.fap;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class Test_ApplicationStudentAdapter extends RecyclerView.Adapter<Test_ApplicationStudentAdapter.ApplicationHolder> {

    List<Test_ApplicationObject> listApplication;

    public Test_ApplicationStudentAdapter(List<Test_ApplicationObject> list) {
        this.listApplication = list;
    }

    @NonNull
    @Override
    public ApplicationHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {

        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.application_student_chapter_card, parent, false);

        return new ApplicationHolder(v);
    }

    @Override
    public void onBindViewHolder(@NonNull ApplicationHolder holder, int position) {
        holder.tv_status.setText(listApplication.get(position).getApplication_status());
        holder.tv_type.setText(listApplication.get(position).getApplication_type());
        holder.tv_date_create.setText(listApplication.get(position).getApplication_create_date());
        holder.tv_response_message.setText(listApplication.get(position).getApplication_res());
        holder.tv_request_message.setText(listApplication.get(position).getApplication_req());
    }

    @Override
    public int getItemCount() {
        return listApplication.size();
    }

    class ApplicationHolder extends RecyclerView.ViewHolder {

        TextView tv_status;
        TextView tv_type;
        TextView tv_date_create;
        TextView tv_response_message;
        TextView tv_request_message;

        public ApplicationHolder(@NonNull View itemView) {
            super(itemView);
            tv_status = itemView.findViewById(R.id.tv_status);
            tv_type = itemView.findViewById(R.id.tv_type);
            tv_date_create = itemView.findViewById(R.id.tv_date_create);
            tv_response_message = itemView.findViewById(R.id.tv_response_message);
            tv_request_message = itemView.findViewById(R.id.tv_request_message);
        }
    }
}
