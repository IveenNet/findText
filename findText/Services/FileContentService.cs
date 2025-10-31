namespace findText.Services
{
    // FileContentService.cs
    public class FileContentService
    {
        public string File1Content { get; set; } = string.Empty;
        public string File2Content { get; set; } = string.Empty;

        public event Action OnChange;

        public void SetFileContent(int fileNumber, string content)
        {
            if (fileNumber == 1)
                File1Content = content;
            else if (fileNumber == 2)
                File2Content = content;

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        public string GetCombinedContent()
        {
            // Esta es la lógica para el textarea central
            return $"--- Contenido Archivo 1 ---\n{File1Content}\n\n--- Contenido Archivo 2 ---\n{File2Content}";
        }
    }
}
