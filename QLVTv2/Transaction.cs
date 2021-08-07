using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVTv2
{
    interface Transaction
    {
        void execute();
        void commit();
        void undo();
        void redo();

    }

    class TransactionControl
    {
        private Stack<Transaction> undoStack;
        private Stack<Transaction> redoStack;

        public TransactionControl()
        {
            undoStack = new Stack<Transaction>();
            redoStack = new Stack<Transaction>();
        }

        public Transaction getLastUndoNode()
        {
            return undoStack.Peek();
        }

        public int undoStackSize()
        {
            return undoStack.Count;
        }

        public int redoStackSize()
        {
            return redoStack.Count;
        }

        public void execute(Transaction transaction)
        { // dung cho action 1 giai doan (delete)
            transaction.execute();
            undoStack.Push(transaction);
            redoStack.Clear(); // xoa redo khi user thao tac
        }

        // prepare commit danh 2 loai action su dung 2 giai doan (insert,update)
        public void prepare(Transaction transaction)
        {
            transaction.execute();
            undoStack.Push(transaction);
        }

        public void commit()
        {
            undoStack.Peek().commit();
            redoStack.Clear();// xoa redo khi user thao tac
        }

        public void undo()
        {
            Transaction transaction = undoStack.Pop();
            transaction.undo();
            redoStack.Push(transaction);
        }

        public void redo()
        {
            Transaction transaction = redoStack.Pop();
            transaction.redo();
            undoStack.Push(transaction);
        }
        public void clear()
        {
            undoStack.Clear();
            redoStack.Clear();
        }

        // khi user chon update/insert nhung cancel ma k commit
        public void clearLastNode()
        {
            undoStack.Pop();
        }
    }

    class DeleteTransaction : Transaction
    {
        public BindingSource binding;
        public Object prime; // khoa chinh
        public Object[] data;
        public String primeName;

        public DeleteTransaction(BindingSource binding, string primeName)
        {
            this.binding = binding;
            this.primeName = primeName;
        }

        public void commit()
        {
        }

        public void execute()
        {
            // save lai data
            data = ((DataRowView)binding.Current).Row.ItemArray;
            prime = data[0];
            // thuc thi delete tai vi tri user chon
            binding.RemoveCurrent(); // delete dong hien tai (user chi dinh)
        }

        public void redo()
        {
            // thuc thi delete tai khoa chinh
            int pos;
            for (pos = 0; pos < binding.Count; pos++)
            {
                if (((DataRowView)binding[pos])[primeName].ToString().Trim() == prime.ToString().Trim())
                {
                    break;
                }
            }
            //int pos = binding.Find(primeName, prime);
            binding.RemoveAt(pos); // delete lai dong do
        }

        public void undo()
        {
            // insert lai data o vi tri cuoi (do k biet insert lai dung vi tri)
            binding.AddNew();
            DataRowView row = (DataRowView)binding.Current;
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }

            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.MoveLast(); // di den vi tri vua insert lai
        }
    }

    class InsertTransaction : Transaction
    {
        public BindingSource binding;
        public Object[] data;
        public Object prime;
        String primeName;

        public InsertTransaction(BindingSource binding, string primeName)
        {
            this.binding = binding;
            this.primeName = primeName;
        }

        public void commit()
        {
        }

        public void execute()
        {
            data = ((DataRowView)binding.Current).Row.ItemArray;
            prime = data[0];
        }

        public void redo()
        {
            binding.AddNew(); // tao dong trong va nhay xuong cho edit
            // update lai data
            DataRowView row = (DataRowView)binding[binding.Position];
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.MoveLast(); // di den vi tri insert lai
        }

        public void undo()
        {
            // delete record dc insert tai vi tri da save
            int pos;
            for (pos = 0; pos < binding.Count; pos++)
            {
                if (((DataRowView)binding[pos])[primeName].ToString().Trim() == prime.ToString().Trim())
                {
                    break;
                }
            }
            //   int pos = binding.Find(primeName, prime);
            binding.RemoveAt(pos);
        }
    }

    class UpdateTransaction : Transaction
    {
        BindingSource binding;
        Object prime;
        String primeName;
        Object[] oldData;
        Object[] newData;

        public UpdateTransaction(BindingSource binding, string primeName)
        {
            this.binding = binding;
            this.primeName = primeName;
        }

        public void commit()
        {
            binding.EndEdit();
            binding.ResetCurrentItem();
            newData = ((DataRowView)binding.Current).Row.ItemArray;
        }

        public void execute()
        {
            // save lai data
            oldData = ((DataRowView)binding.Current).Row.ItemArray;
            prime = oldData[0]; // do khoa chinh khong dc thay doi khi update -> su dung luon old data
        }

        public void redo()
        {
            // update lai data
            int pos = binding.Find(primeName, prime);
            DataRowView row = (DataRowView)binding[pos];
            for (int i = 0; i < oldData.Length; i++)
            {
                row[i] = newData[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.Position = pos; // di chuyen den vi tri dong dc redo       
        }

        public void undo()
        {
            int pos = binding.Find(primeName, prime);
            // update lai data
            DataRowView row = (DataRowView)binding[pos];
            for (int i = 0; i < oldData.Length; i++)
            {
                row[i] = oldData[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            binding.Position = pos;
        }
    }
}
